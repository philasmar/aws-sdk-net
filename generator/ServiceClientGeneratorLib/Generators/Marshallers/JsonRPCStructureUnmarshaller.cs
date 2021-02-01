// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class JsonRPCStructureUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using ThirdParty.Json.LitJson;\r\n\r\nnamespace ");
            
            #line 13 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Object\r\n    /// </summary>  \r\n    public class ");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Unmarshaller : IUnmarshaller<");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(", XmlUnmarshallerContext>, IUnmarshaller<");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(", JsonUnmarshallerContext>\r\n    {\r\n        /// <summary>\r\n        /// Unmarshalle" +
                    "r the response from the service to the response class.\r\n        /// </summary>  " +
                    "\r\n        /// <param name=\"context\"></param>\r\n        /// <returns></returns>\r\n " +
                    "       ");
            
            #line 25 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" IUnmarshaller<");
            
            #line 25 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@", XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name=""context""></param>
        /// <returns></returns>
        public ");
            
            #line 35 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Unmarshall(JsonUnmarshallerContext context)\r\n        {\r\n            context.Read" +
                    "();\r\n            if (context.CurrentTokenType == JsonToken.Null) \r\n             " +
                    "   return null;\r\n\r\n            ");
            
            #line 41 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" unmarshalledObject = new ");
            
            #line 41 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("();\r\n        \r\n            int targetDepth = context.CurrentDepth;\r\n            w" +
                    "hile (context.ReadAtDepth(targetDepth))\r\n            {\r\n");
            
            #line 46 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"

    if(this.Structure != null)
    {
        foreach (var member in this.Structure.Members)
        {

            
            #line default
            #line hidden
            this.Write("                if (context.TestExpression(\"");
            
            #line 52 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                {\r\n                    var unmarshaller = ");
            
            #line 54 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n                    unmarshalledObject.");
            
            #line 55 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n                    continue;\r\n            " +
                    "    }\r\n");
            
            #line 58 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("            }\r\n          \r\n            return unmarshalledObject;\r\n        }\r\n\r\n\r" +
                    "\n");
            
            #line 68 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureUnmarshaller.tt"

    this.AddStructureSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
