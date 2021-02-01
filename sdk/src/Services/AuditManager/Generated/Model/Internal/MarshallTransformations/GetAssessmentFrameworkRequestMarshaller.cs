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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAssessmentFramework Request Marshaller
    /// </summary>       
    public class GetAssessmentFrameworkRequestMarshaller : IMarshaller<IRequest, GetAssessmentFrameworkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAssessmentFrameworkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAssessmentFrameworkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFrameworkId())
                throw new AmazonAuditManagerException("Request object does not have required field FrameworkId set");
            request.AddPathResource("{frameworkId}", StringUtils.FromString(publicRequest.FrameworkId));
            request.ResourcePath = "/assessmentFrameworks/{frameworkId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetAssessmentFrameworkRequestMarshaller _instance = new GetAssessmentFrameworkRequestMarshaller();        

        internal static GetAssessmentFrameworkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAssessmentFrameworkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}