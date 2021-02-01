// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.NuGet
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class Nuspec : NuspecBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<package> \r\n  <metadata> \r\n    <id>");
            
            #line 10 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write("</id>\r\n    <title>");
            
            #line 11 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NuGetTitle"]));
            
            #line default
            #line hidden
            this.Write("</title>\r\n    <version>");
            
            #line 12 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NuGetPreviewFlag"]));
            
            #line default
            #line hidden
            this.Write("</version> \r\n    <authors>Amazon Web Services</authors>\r\n    <description>");
            
            #line 14 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyDescription"]));
            
            #line default
            #line hidden
            this.Write("</description>\r\n    <language>en-US</language>\r\n    <licenseUrl>");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["licenseUrl"]));
            
            #line default
            #line hidden
            this.Write("</licenseUrl>\r\n    <projectUrl>https://github.com/aws/aws-sdk-net/</projectUrl>\r\n" +
                    "    <tags>AWS Amazon cloud ");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BaseName"]));
            
            #line default
            #line hidden
            this.Write(" aws-sdk-v3");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ExtraTags"]));
            
            #line default
            #line hidden
            this.Write("</tags>\r\n    <iconUrl>https://sdk-for-net.amazonwebservices.com/images/AWSLogo128" +
                    "x128.png</iconUrl>\r\n");
            
            #line 20 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
 
    if (bool.Parse(this.Session["requireLicenseAcceptance"].ToString()))
	{
            
            #line default
            #line hidden
            this.Write("    <requireLicenseAcceptance>");
            
            #line 23 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["requireLicenseAcceptance"]));
            
            #line default
            #line hidden
            this.Write("</requireLicenseAcceptance>\r\n");
            
            #line 24 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
 
	}

            
            #line default
            #line hidden
            this.Write("    <dependencies>\r\n");
            
            #line 28 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

	if(this.Session.ContainsKey("NugetDependencies"))
    {
		var dependencies = (Dictionary<string,List<Dependency>>)this.Session["NugetDependencies"];
		foreach(var dependencyList in dependencies)
		{
			var projectFileConfigurations = (IEnumerable<ProjectFileConfiguration>)this.Session["ProjectFileConfigurations"];
			var targetFramework = projectFileConfigurations.Single(p=>p.Name.Equals(dependencyList.Key)).NuGetTargetPlatform;

            
            #line default
            #line hidden
            this.Write("\t\t\t\r\n      <group targetFramework=\"");
            
            #line 37 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetFramework));
            
            #line default
            #line hidden
            this.Write("\">\r\n");
            
            #line 38 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

            foreach(var dependency in dependencyList.Value)
            {

            
            #line default
            #line hidden
            this.Write("        <dependency id=\"");
            
            #line 42 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 42 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Version));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 43 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
		
            }

            
            #line default
            #line hidden
            
            #line 46 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

            foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
            {

            
            #line default
            #line hidden
            this.Write("        <dependency id=\"");
            
            #line 50 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 50 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 51 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

            }

            
            #line default
            #line hidden
            this.Write("      </group>\r\n");
            
            #line 55 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

		}
	}	

            
            #line default
            #line hidden
            this.Write("      <group>\r\n");
            
            #line 60 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("        <dependency id=\"");
            
            #line 64 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 64 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 65 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    }

            
            #line default
            #line hidden
            this.Write("      </group>\r\n    </dependencies>\r\n  </metadata> \r\n  <files>\r\n\r\n    <file src=\"" +
                    "..\\..\\..\\code-analysis\\ServiceAnalysis\\");
            
            #line 73 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["CodeAnalysisServiceFolder"]));
            
            #line default
            #line hidden
            this.Write(@"\bin\Release\*.dll"" target=""analyzers\dotnet\cs"" exclude=""**\Microsoft.CodeAnalysis.*;**\System.Collections.Immutable.*;**\System.Reflection.Metadata.*;**\System.Composition.*"" />
    <file src=""..\..\..\code-analysis\NuGetInstallScripts\*.ps1"" target=""tools\"" />

    <file src="".\bin\Release\net35\");
            
            #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".dll\" target=\"lib\\net35\" />\r\n    <file src=\".\\bin\\Release\\net35\\");
            
            #line 77 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".xml\" target=\"lib\\net35\" />\r\n    <file src=\".\\bin\\Release\\net35\\");
            
            #line 78 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".pdb\" target=\"lib\\net35\" />\r\n\r\n    <file src=\".\\bin\\Release\\net45\\");
            
            #line 80 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".dll\" target=\"lib\\net45\" />\r\n    <file src=\".\\bin\\Release\\net45\\");
            
            #line 81 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".xml\" target=\"lib\\net45\" />\r\n    <file src=\".\\bin\\Release\\net45\\");
            
            #line 82 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".pdb\" target=\"lib\\net45\" />\r\n\r\n");
            
            #line 84 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
	
	if(Convert.ToBoolean(this.Session["NetStandardSupport"]))
	{

            
            #line default
            #line hidden
            this.Write("    <file src=\"");
            
            #line 88 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netstandard1.3", (string)this.Session["AssemblyName"] + ".dll")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netstandard1.3\" />\r\n    <file src=\"");
            
            #line 89 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netstandard1.3", (string)this.Session["AssemblyName"] + ".xml")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netstandard1.3\" />\r\n    <file src=\"");
            
            #line 90 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netstandard1.3", (string)this.Session["AssemblyName"] + ".pdb")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netstandard1.3\" />\r\n\r\n\t<file src=\"");
            
            #line 92 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netstandard2.0", (string)this.Session["AssemblyName"] + ".dll")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netstandard2.0\" />\r\n    <file src=\"");
            
            #line 93 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netstandard2.0", (string)this.Session["AssemblyName"] + ".xml")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netstandard2.0\" />\r\n    <file src=\"");
            
            #line 94 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netstandard2.0", (string)this.Session["AssemblyName"] + ".pdb")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netstandard2.0\" />\r\n\r\n    <file src=\"");
            
            #line 96 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netcoreapp3.1", (string)this.Session["AssemblyName"] + ".dll")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netcoreapp3.1\" />\r\n    <file src=\"");
            
            #line 97 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netcoreapp3.1", (string)this.Session["AssemblyName"] + ".xml")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netcoreapp3.1\" />\r\n    <file src=\"");
            
            #line 98 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine(".", "bin", "Release", "netcoreapp3.1", (string)this.Session["AssemblyName"] + ".pdb")));
            
            #line default
            #line hidden
            this.Write("\" target=\"lib\\netcoreapp3.1\" />\r\n");
            
            #line 99 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

	}

            
            #line default
            #line hidden
            this.Write("\r\n  </files>\r\n</package>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class NuspecBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}