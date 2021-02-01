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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListInstances Request Marshaller
    /// </summary>       
    public class ListInstancesRequestMarshaller : IMarshaller<IRequest, ListInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListInstancesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.ListInstances";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2009-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClusterId())
                {
                    context.Writer.WritePropertyName("ClusterId");
                    context.Writer.Write(publicRequest.ClusterId);
                }

                if(publicRequest.IsSetInstanceFleetId())
                {
                    context.Writer.WritePropertyName("InstanceFleetId");
                    context.Writer.Write(publicRequest.InstanceFleetId);
                }

                if(publicRequest.IsSetInstanceFleetType())
                {
                    context.Writer.WritePropertyName("InstanceFleetType");
                    context.Writer.Write(publicRequest.InstanceFleetType);
                }

                if(publicRequest.IsSetInstanceGroupId())
                {
                    context.Writer.WritePropertyName("InstanceGroupId");
                    context.Writer.Write(publicRequest.InstanceGroupId);
                }

                if(publicRequest.IsSetInstanceGroupTypes())
                {
                    context.Writer.WritePropertyName("InstanceGroupTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceGroupTypesListValue in publicRequest.InstanceGroupTypes)
                    {
                            context.Writer.Write(publicRequestInstanceGroupTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInstanceStates())
                {
                    context.Writer.WritePropertyName("InstanceStates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceStatesListValue in publicRequest.InstanceStates)
                    {
                            context.Writer.Write(publicRequestInstanceStatesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMarker())
                {
                    context.Writer.WritePropertyName("Marker");
                    context.Writer.Write(publicRequest.Marker);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListInstancesRequestMarshaller _instance = new ListInstancesRequestMarshaller();        

        internal static ListInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}