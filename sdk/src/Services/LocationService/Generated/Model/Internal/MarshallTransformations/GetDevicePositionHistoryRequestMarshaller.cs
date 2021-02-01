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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDevicePositionHistory Request Marshaller
    /// </summary>       
    public class GetDevicePositionHistoryRequestMarshaller : IMarshaller<IRequest, GetDevicePositionHistoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDevicePositionHistoryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDevicePositionHistoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDeviceId())
                throw new AmazonLocationServiceException("Request object does not have required field DeviceId set");
            request.AddPathResource("{DeviceId}", StringUtils.FromString(publicRequest.DeviceId));
            if (!publicRequest.IsSetTrackerName())
                throw new AmazonLocationServiceException("Request object does not have required field TrackerName set");
            request.AddPathResource("{TrackerName}", StringUtils.FromString(publicRequest.TrackerName));
            request.ResourcePath = "/tracking/v0/trackers/{TrackerName}/devices/{DeviceId}/list-positions";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTimeExclusive())
                {
                    context.Writer.WritePropertyName("EndTimeExclusive");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601(publicRequest.EndTimeExclusive));
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetStartTimeInclusive())
                {
                    context.Writer.WritePropertyName("StartTimeInclusive");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601(publicRequest.StartTimeInclusive));
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"tracking.";

            return request;
        }
        private static GetDevicePositionHistoryRequestMarshaller _instance = new GetDevicePositionHistoryRequestMarshaller();        

        internal static GetDevicePositionHistoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDevicePositionHistoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}