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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutforVision.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutforVision.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeModel Request Marshaller
    /// </summary>       
    public class DescribeModelRequestMarshaller : IMarshaller<IRequest, DescribeModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutforVision");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-20";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetModelVersion())
                throw new AmazonLookoutforVisionException("Request object does not have required field ModelVersion set");
            request.AddPathResource("{modelVersion}", StringUtils.FromString(publicRequest.ModelVersion));
            if (!publicRequest.IsSetProjectName())
                throw new AmazonLookoutforVisionException("Request object does not have required field ProjectName set");
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            request.ResourcePath = "/2020-11-20/projects/{projectName}/models/{modelVersion}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DescribeModelRequestMarshaller _instance = new DescribeModelRequestMarshaller();        

        internal static DescribeModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}