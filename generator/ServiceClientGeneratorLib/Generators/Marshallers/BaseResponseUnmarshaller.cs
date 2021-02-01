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
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class BaseResponseUnmarshaller : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 7 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

    protected void AddCommonUsingStatements()
    {

        
        #line default
        #line hidden
        
        #line 10 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Globalization;\r\nus" +
        "ing System.IO;\r\nusing System.Net;\r\nusing System.Text;\r\nusing System.Xml.Serializ" +
        "ation;\r\n\r\nusing ");

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(".Model;\r\nusing Amazon.Runtime;\r\nusing Amazon.Runtime.Internal;\r\nusing Amazon.Runt" +
        "ime.Internal.Transform;\r\nusing Amazon.Runtime.Internal.Util;\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

    }

    // Set to true when the service model specifies a shape that should be wrapped in a response. ElastiCache CreateCacheCluster is an example of this.
    public bool IsWrapped { get; set; }

    // set to the name of the member in the base Result class for operations where response data is moved from the result
    // class into a structure member. If not set, the response members are assumed to be in the result base class itself.
    public string WrappedResultMember { get; set; }

    // The operation to unmarshall a response from
    public Operation Operation { get; set; }

    Shape _structure;

	// Set if we are generating what is effectively a void response from an operation - no result class or other
	// members were generated
	public bool HasSuppressedResult { get; set; }

	public string BaseException { get; set; }

    // The shape of the response
    public Shape Structure 
    { 
        get 
        { 
            if(this.Operation != null)
			{
				if(this.Operation.IsResponseWrapped)
					return this.Operation.ResponseStructure.Members[0].Shape;
				else
					return this.Operation.ResponseStructure;
			}
            return this._structure; 
        }
        set { this._structure = value; }
    }

    public string UnmarshallerBaseName
    {
        get
        {
            if(this.Operation != null)
                return this.Operation.Name;

            return this.Structure.Name;
        }
    }

    protected void AddResponseSingletonMethod()
    {

        
        #line default
        #line hidden
        
        #line 75 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("        private static ");

        
        #line default
        #line hidden
        
        #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller _instance = new ");

        
        #line default
        #line hidden
        
        #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller();        \r\n\r\n\t\tinternal static ");

        
        #line default
        #line hidden
        
        #line 78 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 78 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller GetInstance()\r\n\t\t{\r\n\t\t\treturn _instance;\r\n\t\t}\r\n\r\n        ///" +
        " <summary>\r\n        /// Gets the singleton.\r\n        /// </summary>  \r\n\t\tpublic " +
        "static ");

        
        #line default
        #line hidden
        
        #line 86 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 86 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller Instance\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn _instance;\r\n\t\t\t}\r\n\t\t" +
        "}\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 94 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

    }

    protected void AddStructureSingletonMethod()
    {

        
        #line default
        #line hidden
        
        #line 99 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("        private static ");

        
        #line default
        #line hidden
        
        #line 100 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 100 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("Unmarshaller _instance = new ");

        
        #line default
        #line hidden
        
        #line 100 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 100 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("Unmarshaller();        \r\n\r\n        /// <summary>\r\n        /// Gets the singleton." +
        "\r\n        /// </summary>  \r\n\t\tpublic static ");

        
        #line default
        #line hidden
        
        #line 105 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 105 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("Unmarshaller Instance\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn _instance;\r\n\t\t\t}\r\n\t\t}\r\n");

        
        #line default
        #line hidden
        
        #line 112 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

	}
	
	// Only applicable for rest-json and rest-xml
    // Generates code to parse present header members into the response object
	protected void UnmarshallHeaders()
	{
		if( this.Operation.ResponseHeaderMembers.Count() > 0 )
		{
			foreach (var member in this.Operation.ResponseHeaderMembers)
			{

        
        #line default
        #line hidden
        
        #line 123 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\tif (context.ResponseData.IsHeaderPresent(\"");

        
        #line default
        #line hidden
        
        #line 124 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 124 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\"))\r\n");

        
        #line default
        #line hidden
        
        #line 125 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

				if (member.Shape.IsString)
				{
					if (member.IsJsonValue)
					{

        
        #line default
        #line hidden
        
        #line 130 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\t{\r\n\t\t\t\tvar headerBytes = Convert.FromBase64String(context.ResponseData.GetHead" +
        "erValue(\"");

        
        #line default
        #line hidden
        
        #line 132 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 132 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\"));\r\n\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 133 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 133 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);\r\n\t\t\t}\r\n");

        
        #line default
        #line hidden
        
        #line 135 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

					}
					else
					{

        
        #line default
        #line hidden
        
        #line 139 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 140 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 140 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = context.ResponseData.GetHeaderValue(\"");

        
        #line default
        #line hidden
        
        #line 140 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 140 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 141 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

					}
				}
				else if (member.Shape.IsInt)
				{

        
        #line default
        #line hidden
        
        #line 146 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 147 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 147 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = int.Parse(context.ResponseData.GetHeaderValue(\"");

        
        #line default
        #line hidden
        
        #line 147 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 147 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\"), CultureInfo.InvariantCulture);\r\n");

        
        #line default
        #line hidden
        
        #line 148 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

				}
				else if (member.Shape.IsLong)
				{

        
        #line default
        #line hidden
        
        #line 152 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 153 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 153 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = long.Parse(context.ResponseData.GetHeaderValue(\"");

        
        #line default
        #line hidden
        
        #line 153 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 153 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\"), CultureInfo.InvariantCulture);\r\n");

        
        #line default
        #line hidden
        
        #line 154 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

				}
				else if (member.Shape.IsDateTime)
				{
					if(	member.TimestampFormat == TimestampFormat.ISO8601 || 
						member.TimestampFormat == TimestampFormat.RFC822)
					{

        
        #line default
        #line hidden
        
        #line 161 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 162 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 162 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = DateTime.Parse(context.ResponseData.GetHeaderValue(\"");

        
        #line default
        #line hidden
        
        #line 162 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 162 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\"), CultureInfo.InvariantCulture);\r\n");

        
        #line default
        #line hidden
        
        #line 163 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"

					}
					else if(member.TimestampFormat == TimestampFormat.UnixTimestamp)
					{

        
        #line default
        #line hidden
        
        #line 167 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 168 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 168 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(context.Response" +
        "Data.GetHeaderValue(\"");

        
        #line default
        #line hidden
        
        #line 168 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 168 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\"), CultureInfo.InvariantCulture));\r\n");

        
        #line default
        #line hidden
        
        #line 169 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
					
					}
					else
					{
						throw new Exception(string.Format("Unable to determine the TimestampFormat for member {0}, type {1}.", member.Shape.Name, member.Shape.Type));
					}
				}
				else
				{
					throw new Exception("Member " + member.Shape.Name + " cannot be handled because its type, " + member.Shape.Type + ", is not handled. Please update BaseResponseUnmarshaller.tt.");
				}
			}
		}
	}

    // Generates code to set the status code of the response, example: 404, 200, etc
	protected void ProcessStatusCode()
	{
		if( this.Operation.ResponseStatusCodeMember != null)
		{

        
        #line default
        #line hidden
        
        #line 189 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write("\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 190 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.ResponseStatusCodeMember.PropertyName));

        
        #line default
        #line hidden
        
        #line 190 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
this.Write(" = (int)context.ResponseData.StatusCode;\r\n");

        
        #line default
        #line hidden
        
        #line 191 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseResponseUnmarshaller.tt"
						
		}
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
