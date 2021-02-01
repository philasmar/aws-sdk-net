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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStreamingURL Request Marshaller
    /// </summary>       
    public class CreateStreamingURLRequestMarshaller : IMarshaller<IRequest, CreateStreamingURLRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStreamingURLRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStreamingURLRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateStreamingURL";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationId())
                {
                    context.Writer.WritePropertyName("ApplicationId");
                    context.Writer.Write(publicRequest.ApplicationId);
                }

                if(publicRequest.IsSetFleetName())
                {
                    context.Writer.WritePropertyName("FleetName");
                    context.Writer.Write(publicRequest.FleetName);
                }

                if(publicRequest.IsSetSessionContext())
                {
                    context.Writer.WritePropertyName("SessionContext");
                    context.Writer.Write(publicRequest.SessionContext);
                }

                if(publicRequest.IsSetStackName())
                {
                    context.Writer.WritePropertyName("StackName");
                    context.Writer.Write(publicRequest.StackName);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("UserId");
                    context.Writer.Write(publicRequest.UserId);
                }

                if(publicRequest.IsSetValidity())
                {
                    context.Writer.WritePropertyName("Validity");
                    context.Writer.Write(publicRequest.Validity);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateStreamingURLRequestMarshaller _instance = new CreateStreamingURLRequestMarshaller();        

        internal static CreateStreamingURLRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStreamingURLRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}