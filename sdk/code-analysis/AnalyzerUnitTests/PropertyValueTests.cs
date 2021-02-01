﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestHelper;

using MockAnalyzer;

namespace Analyzer1.Test
{
    [TestClass]
    public class PropertyValueTests : DiagnosticVerifier
    {

        //Diagnostic and CodeFix both triggered and checked for
        [TestMethod]
        public void TestStringRules()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Name = ""aa""
            }
        }

        public class AnalyzedClass
        {
            public string Name {get; set;}
        }
    }";
            var expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1000",
                Message = "Value \"aa\" is too short for Name, it must be at least 3 characters",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 29)
                        }
            };

            VerifyCSharpDiagnostic(test, expected);


            test = test.Replace("\"aa\"", "\"aaa\"");
            VerifyCSharpDiagnostic(test);

            test = test.Replace("\"aaa\"", "\"aaaaa\"");
            VerifyCSharpDiagnostic(test);

            test = test.Replace("\"aaaaa\"", "\"aaaaaa\"");

            expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1001",
                Message = "Value \"aaaaaa\" is too long for Name, it must be at most 5 characters",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 29)
                        }
            };

            VerifyCSharpDiagnostic(test, expected);


            test = test.Replace("\"aaaaaa\"", "\"#aaa\"");

            expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1002",
                Message = "Value \"#aaa\" does not match required pattern \"[0-9a-z\\-_]+\" for property Name",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 29)
                        }
            };

            VerifyCSharpDiagnostic(test, expected);
        }

        [TestMethod]
        public void TestIntRules()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Size = 9;
            }
        }

        public class AnalyzedClass
        {
            public int Size {get; set;}
        }
    }";
            var expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1003",
                Message = "Value \"9\" is less than minimum of 10 for property Size",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 29)
                        }
            };

            VerifyCSharpDiagnostic(test, expected);


            test = test.Replace("9", "10");
            VerifyCSharpDiagnostic(test);

            test = test.Replace("10", "20");
            VerifyCSharpDiagnostic(test);

            test = test.Replace("20", "21");

            expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1004",
                Message = "Value \"21\" is greater than maximum of 20 for property Size",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 29)
                        }
            };

            VerifyCSharpDiagnostic(test, expected);
        }

        [TestMethod]
        public void TestNonLiteralExpression()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Size = expression;
            }
        }

        public class AnalyzedClass
        {
            public int Size {get; set;}
        }
    }";
            var expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1003",
                Message = "Value \"-1\" is less than minimum of 10 for property Size",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 29)
                        }
            };

            string testCode = test.Replace("expression", "(-1)");
            VerifyCSharpDiagnostic(testCode, expected);

            testCode = test.Replace("expression", "2-3");
            VerifyCSharpDiagnostic(testCode, expected);

            testCode = test.Replace("expression", "(2*3)-7");
            VerifyCSharpDiagnostic(testCode, expected);

            testCode = test.Replace("expression", "(2*3)-someValue");
            VerifyCSharpDiagnostic(testCode);

            test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Name = expression
            }
        }

        public class AnalyzedClass
        {
            public string Name {get; set;}
        }
    }";

            expected = new DiagnosticResult
            {
                Id = "MockAnalyzer1000",
                Message = "Value \"aa\" is too short for Name, it must be at least 3 characters",
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 16, 30)
                        }
            };

            testCode = test.Replace("expression", @" ""a"" + ""a"" ");
            VerifyCSharpDiagnostic(testCode, expected);

            testCode = test.Replace("expression", @"string.Format(""aa"")");
            VerifyCSharpDiagnostic(testCode);
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PropertyValueAssignmentAnalyzer();
        }
    }
}