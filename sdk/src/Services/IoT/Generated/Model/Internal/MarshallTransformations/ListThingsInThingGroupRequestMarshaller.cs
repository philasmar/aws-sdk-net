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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListThingsInThingGroup Request Marshaller
    /// </summary>       
    public class ListThingsInThingGroupRequestMarshaller : IMarshaller<IRequest, ListThingsInThingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListThingsInThingGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListThingsInThingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetThingGroupName())
                throw new AmazonIoTException("Request object does not have required field ThingGroupName set");
            request.AddPathResource("{thingGroupName}", StringUtils.FromString(publicRequest.ThingGroupName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetRecursive())
                request.Parameters.Add("recursive", StringUtils.FromBool(publicRequest.Recursive));
            request.ResourcePath = "/thing-groups/{thingGroupName}/things";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListThingsInThingGroupRequestMarshaller _instance = new ListThingsInThingGroupRequestMarshaller();        

        internal static ListThingsInThingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListThingsInThingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}