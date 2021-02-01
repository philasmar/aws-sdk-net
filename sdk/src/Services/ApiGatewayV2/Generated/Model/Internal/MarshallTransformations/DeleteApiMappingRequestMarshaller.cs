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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteApiMapping Request Marshaller
    /// </summary>       
    public class DeleteApiMappingRequestMarshaller : IMarshaller<IRequest, DeleteApiMappingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteApiMappingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteApiMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetApiMappingId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiMappingId set");
            request.AddPathResource("{apiMappingId}", StringUtils.FromString(publicRequest.ApiMappingId));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field DomainName set");
            request.AddPathResource("{domainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/v2/domainnames/{domainName}/apimappings/{apiMappingId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteApiMappingRequestMarshaller _instance = new DeleteApiMappingRequestMarshaller();        

        internal static DeleteApiMappingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteApiMappingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}