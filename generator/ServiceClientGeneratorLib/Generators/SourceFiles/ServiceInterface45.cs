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
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceInterface45 : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Threading;\r\nusing System.Threading.Tasks;\r\nusing " +
                    "System.Collections.Generic;\r\n\r\nusing Amazon.Runtime;\r\nusing ");
            
            #line 17 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\n\r\nnamespace ");
            
            #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 21 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
    this.FormatServiceInterfaceDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("\tpublic partial interface IAmazon");
            
            #line 22 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" : IAmazonService, IDisposable\r\n\t{\r\n\r\n");
            
            #line 25 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

// Creates paginators for service if available
if (this.Config.ServiceModel.HasPaginators)
{

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Paginators for the service\r\n        /// </summ" +
                    "ary>\r\n        I");
            
            #line 33 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory Paginators { get; }\r\n");
            
            #line 34 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 38 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

    // Generates definitions for each operation in the service model
		foreach(var operation in this.Config.ServiceModel.Operations)
		{
            if(operation.IsInternal)
                continue;
		
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#region  ");
            
            #line 46 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 48 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

        // Creates a parameterless definition of the operation if specified in the customizations file
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 53 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

this.FormatOperationDocumentationSync(operation, false);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 59 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 62 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 62 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n");
            
            #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

        }
        // Adds simple method forms defined in the customizations file
        AddSimpleClientMethodInterfaces(operation, true);

            
            #line default
            #line hidden
            
            #line 69 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

this.FormatOperationDocumentationSync(operation, true);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 74 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 75 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request);\r\n\r\n");
            
            #line 80 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

        // Creates a parameterless definition of the operation if specified in the customizations file
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

			this.FormatOperationDocumentationAsync(operation, false);
			if(operation.IsDeprecated)
			{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 90 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 91 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
		
			}

            
            #line default
            #line hidden
            this.Write("        Task<");
            
            #line 94 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response> ");
            
            #line 94 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Async(System.Threading.CancellationToken cancellationToken = default(Cancellation" +
                    "Token));\r\n\r\n");
            
            #line 96 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

        }

			AddSimpleClientMethodInterfaces(operation, false);

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 102 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

			this.FormatOperationDocumentationAsync(operation, true);
			if(operation.IsDeprecated)
			{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 107 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 108 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
		
			}

            
            #line default
            #line hidden
            this.Write("        Task<");
            
            #line 111 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response> ");
            
            #line 111 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 111 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, CancellationToken cancellationToken = default(CancellationToken)" +
                    ");\r\n\r\n\t\t#endregion\r\n\t\t");
            
            #line 114 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface45.tt"

		}
		
            
            #line default
            #line hidden
            this.Write("\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}