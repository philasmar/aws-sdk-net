﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseRequest.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class BaseRequest : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseRequest.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\nusing Amazon.Runtime;\r\n\r\nnamespace ");
            
            #line 12 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseRequest.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Base class for ");
            
            #line 15 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseRequest.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" operation requests.\r\n    /// </summary>\r\n    public partial class Amazon");
            
            #line 17 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseRequest.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Request : AmazonWebServiceRequest\r\n    {\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
