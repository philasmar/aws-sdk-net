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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNetworkProfile Request Marshaller
    /// </summary>       
    public class CreateNetworkProfileRequestMarshaller : IMarshaller<IRequest, CreateNetworkProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNetworkProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DeviceFarm");
            string target = "DeviceFarm_20150623.CreateNetworkProfile";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-06-23";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDownlinkBandwidthBits())
                {
                    context.Writer.WritePropertyName("downlinkBandwidthBits");
                    context.Writer.Write(publicRequest.DownlinkBandwidthBits);
                }

                if(publicRequest.IsSetDownlinkDelayMs())
                {
                    context.Writer.WritePropertyName("downlinkDelayMs");
                    context.Writer.Write(publicRequest.DownlinkDelayMs);
                }

                if(publicRequest.IsSetDownlinkJitterMs())
                {
                    context.Writer.WritePropertyName("downlinkJitterMs");
                    context.Writer.Write(publicRequest.DownlinkJitterMs);
                }

                if(publicRequest.IsSetDownlinkLossPercent())
                {
                    context.Writer.WritePropertyName("downlinkLossPercent");
                    context.Writer.Write(publicRequest.DownlinkLossPercent);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProjectArn())
                {
                    context.Writer.WritePropertyName("projectArn");
                    context.Writer.Write(publicRequest.ProjectArn);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

                if(publicRequest.IsSetUplinkBandwidthBits())
                {
                    context.Writer.WritePropertyName("uplinkBandwidthBits");
                    context.Writer.Write(publicRequest.UplinkBandwidthBits);
                }

                if(publicRequest.IsSetUplinkDelayMs())
                {
                    context.Writer.WritePropertyName("uplinkDelayMs");
                    context.Writer.Write(publicRequest.UplinkDelayMs);
                }

                if(publicRequest.IsSetUplinkJitterMs())
                {
                    context.Writer.WritePropertyName("uplinkJitterMs");
                    context.Writer.Write(publicRequest.UplinkJitterMs);
                }

                if(publicRequest.IsSetUplinkLossPercent())
                {
                    context.Writer.WritePropertyName("uplinkLossPercent");
                    context.Writer.Write(publicRequest.UplinkLossPercent);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateNetworkProfileRequestMarshaller _instance = new CreateNetworkProfileRequestMarshaller();        

        internal static CreateNetworkProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNetworkProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}