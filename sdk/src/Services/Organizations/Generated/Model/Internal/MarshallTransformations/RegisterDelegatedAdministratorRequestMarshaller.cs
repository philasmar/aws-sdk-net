/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Organizations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Organizations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterDelegatedAdministrator Request Marshaller
    /// </summary>       
    public class RegisterDelegatedAdministratorRequestMarshaller : IMarshaller<IRequest, RegisterDelegatedAdministratorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterDelegatedAdministratorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterDelegatedAdministratorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Organizations");
            string target = "AWSOrganizationsV20161128.RegisterDelegatedAdministrator";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountId())
                {
                    context.Writer.WritePropertyName("AccountId");
                    context.Writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetServicePrincipal())
                {
                    context.Writer.WritePropertyName("ServicePrincipal");
                    context.Writer.Write(publicRequest.ServicePrincipal);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterDelegatedAdministratorRequestMarshaller _instance = new RegisterDelegatedAdministratorRequestMarshaller();        

        internal static RegisterDelegatedAdministratorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterDelegatedAdministratorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}