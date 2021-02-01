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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateComponent Request Marshaller
    /// </summary>       
    public class UpdateComponentRequestMarshaller : IMarshaller<IRequest, UpdateComponentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateComponentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationInsights");
            string target = "EC2WindowsBarleyService.UpdateComponent";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-25";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComponentName())
                {
                    context.Writer.WritePropertyName("ComponentName");
                    context.Writer.Write(publicRequest.ComponentName);
                }

                if(publicRequest.IsSetNewComponentName())
                {
                    context.Writer.WritePropertyName("NewComponentName");
                    context.Writer.Write(publicRequest.NewComponentName);
                }

                if(publicRequest.IsSetResourceGroupName())
                {
                    context.Writer.WritePropertyName("ResourceGroupName");
                    context.Writer.Write(publicRequest.ResourceGroupName);
                }

                if(publicRequest.IsSetResourceList())
                {
                    context.Writer.WritePropertyName("ResourceList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceListListValue in publicRequest.ResourceList)
                    {
                            context.Writer.Write(publicRequestResourceListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateComponentRequestMarshaller _instance = new UpdateComponentRequestMarshaller();        

        internal static UpdateComponentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateComponentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}