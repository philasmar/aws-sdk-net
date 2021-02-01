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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportSshPublicKey Request Marshaller
    /// </summary>       
    public class ImportSshPublicKeyRequestMarshaller : IMarshaller<IRequest, ImportSshPublicKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportSshPublicKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportSshPublicKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.ImportSshPublicKey";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetServerId())
                {
                    context.Writer.WritePropertyName("ServerId");
                    context.Writer.Write(publicRequest.ServerId);
                }

                if(publicRequest.IsSetSshPublicKeyBody())
                {
                    context.Writer.WritePropertyName("SshPublicKeyBody");
                    context.Writer.Write(publicRequest.SshPublicKeyBody);
                }

                if(publicRequest.IsSetUserName())
                {
                    context.Writer.WritePropertyName("UserName");
                    context.Writer.Write(publicRequest.UserName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ImportSshPublicKeyRequestMarshaller _instance = new ImportSshPublicKeyRequestMarshaller();        

        internal static ImportSshPublicKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportSshPublicKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}