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
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class EndpointDiscoveryMarshaller : BaseMarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();
    AddSource();

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 12 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
    
    // The operation to unmarshall a response from
    public Operation Operation { get; set; }

    protected void AddSingletonMethod()
    {

        
        #line default
        #line hidden
        
        #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("        private static ");

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("EndpointDiscoveryMarshaller _instance = new ");

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("EndpointDiscoveryMarshaller();\r\n\r\n        /// <summary>\r\n        /// Gets the sin" +
        "gleton.\r\n        /// </summary>  \r\n\t\tpublic static ");

        
        #line default
        #line hidden
        
        #line 24 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 24 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("EndpointDiscoveryMarshaller Instance\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn _instance;\r\n\t" +
        "\t\t}\r\n\t\t}\r\n");

        
        #line default
        #line hidden
        
        #line 31 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"

	}		
    
    protected void ProcessRequestEndpointDiscoveryIds(string variableName, IEnumerable<Member> members)
	{
		foreach(var member in members)
		{			

        
        #line default
        #line hidden
        
        #line 38 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("\t\t\tif(");

        
        #line default
        #line hidden
        
        #line 39 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 39 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 39 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 39 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("())\r\n\t\t\t\tendpointDiscoveryData.Identifiers.Add(\"");

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("\", ");

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PrimitiveMarshaller));

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 41 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
		
		}
	}

    protected void AddSource()
    {

        
        #line default
        #line hidden
        
        #line 47 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("namespace ");

        
        #line default
        #line hidden
        
        #line 48 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));

        
        #line default
        #line hidden
        
        #line 48 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Endpoint d" +
        "iscovery parameters for ");

        
        #line default
        #line hidden
        
        #line 51 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 51 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(" operation\r\n    /// </summary>  \r\n    public class ");

        
        #line default
        #line hidden
        
        #line 53 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 53 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("EndpointDiscoveryMarshaller : IMarshaller<EndpointDiscoveryDataBase, ");

        
        #line default
        #line hidden
        
        #line 53 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 53 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(@"Request> , IMarshaller<EndpointDiscoveryDataBase,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the endpoint discovery object.
        /// </summary>  
        /// <param name=""input""></param>
        /// <returns></returns>
		public EndpointDiscoveryDataBase Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((");

        
        #line default
        #line hidden
        
        #line 62 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 62 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(@"Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name=""publicRequest""></param>
        /// <returns></returns>
		public EndpointDiscoveryDataBase Marshall(");

        
        #line default
        #line hidden
        
        #line 70 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));

        
        #line default
        #line hidden
        
        #line 70 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("Request publicRequest)\r\n\t\t{\r\n\t\t\tvar endpointDiscoveryData = new EndpointDiscovery" +
        "Data(");

        
        #line default
        #line hidden
        
        #line 72 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.IsEndpointDiscoveryRequired.ToString().ToLowerInvariant()));

        
        #line default
        #line hidden
        
        #line 72 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write(");\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 74 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"

	if(this.Operation.RequestHasEndpointDiscoveryIdMembers)
	{
		ProcessRequestEndpointDiscoveryIds("publicRequest", this.Operation.RequestEndpointDiscoveryIdMembers);		
	}

        
        #line default
        #line hidden
        
        #line 79 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("\t\t\treturn endpointDiscoveryData;\r\n\t\t}\r\n        \r\n");

        
        #line default
        #line hidden
        
        #line 83 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"

    this.AddSingletonMethod();

        
        #line default
        #line hidden
        
        #line 85 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"
this.Write("      \r\n    }\r\n}\r\n");

        
        #line default
        #line hidden
        
        #line 88 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\EndpointDiscoveryMarshaller.tt"

    }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
