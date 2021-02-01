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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDomainStatisticsReport Request Marshaller
    /// </summary>       
    public class GetDomainStatisticsReportRequestMarshaller : IMarshaller<IRequest, GetDomainStatisticsReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDomainStatisticsReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDomainStatisticsReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomain())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field Domain set");
            request.AddPathResource("{Domain}", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetEndDate())
                request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601(publicRequest.EndDate));
            
            if (publicRequest.IsSetStartDate())
                request.Parameters.Add("StartDate", StringUtils.FromDateTimeToISO8601(publicRequest.StartDate));
            request.ResourcePath = "/v2/email/deliverability-dashboard/statistics-report/{Domain}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static GetDomainStatisticsReportRequestMarshaller _instance = new GetDomainStatisticsReportRequestMarshaller();        

        internal static GetDomainStatisticsReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDomainStatisticsReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}