﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.TestFiles
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AWSQueryMarshallingTests : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.IO;\r\nusing System.Linq;\r\nusing System.Text;\r\nusin" +
                    "g Microsoft.VisualStudio.TestTools.UnitTesting;\r\n\r\nusing ");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 20 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations;\r\nusing Amazon.Runtime.Internal.Transform" +
                    ";\r\n\r\nusing ServiceClientGenerator;\r\n\r\nusing AWSSDK_DotNet35.UnitTests.TestTools;" +
                    "\r\n\r\nnamespace AWSSDK_DotNet35.UnitTests.Marshalling\r\n{\r\n    [TestClass]\r\n    pub" +
                    "lic class ");
            
            #line 30 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("MarshallingTests\r\n    {\r\n        static readonly ServiceModel service_model = Uti" +
                    "ls.LoadServiceModel(\"");
            
            #line 32 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceDirectoryName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t");
            
            #line 33 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
		
            
            #line default
            #line hidden
            this.Write("\r\n        [TestMethod]\r\n        [TestCategory(\"UnitTest\")]\r\n        [TestCategory" +
                    "(\"");
            
            #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.Type));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        [TestCategory(\"");
            
            #line 41 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.TestCategory));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 42 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n            var operation = service_model.FindOperatio" +
                    "n(\"");
            
            #line 44 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\n            var request = InstantiateClassGenerator.Execute<");
            
            #line 46 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 47 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n            var internalRequest = marshaller.Marshall(reque" +
                    "st);\r\n            var validator = new AWSQueryValidator(internalRequest.Paramete" +
                    "rs, request, service_model, operation);\r\n            validator.Validate();\r\n\r\n\r\n" +
                    "");
            
            #line 53 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"

            if(operation.ResponseStructure != null)
            {

            
            #line default
            #line hidden
            this.Write("            var payloadResponse = new XmlSampleGenerator(service_model, operation" +
                    ").Execute();\r\n\t\t\tvar context = new XmlUnmarshallerContext(Utils.CreateStreamFrom" +
                    "String(payloadResponse), false, null);\r\n            var response = ");
            
            #line 59 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance.Unmarshall(context)\r\n\t\t\t\tas ");
            
            #line 60 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response;   \r\n            InstantiateClassGenerator.ValidateObjectFullyInstantiat" +
                    "ed(response);       \r\n");
            
            #line 62 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 66 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"

            foreach (var exception in operation.Exceptions)
            {

            
            #line default
            #line hidden
            this.Write("\r\n        [TestMethod]\r\n        [TestCategory(\"UnitTest\")]\r\n        [TestCategory" +
                    "(\"");
            
            #line 73 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.Type));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        [TestCategory(\"");
            
            #line 74 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.TestCategory));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 75 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("_");
            
            #line 75 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n            var operation = service_model.FindOperatio" +
                    "n(\"");
            
            #line 77 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\n            var request = InstantiateClassGenerator.Execute<");
            
            #line 79 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 80 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write(@"RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals(""");
            
            #line 86 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write(@"""));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ");
            
            #line 89 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpS" +
                    "tatusCode.OK);\r\n\r\n            InstantiateClassGenerator.ValidateObjectFullyInsta" +
                    "ntiated(response);\r\n        }\r\n");
            
            #line 93 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryMarshallingTests.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
