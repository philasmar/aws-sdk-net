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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAccessPoint Request Marshaller
    /// </summary>       
    public class GetAccessPointRequestMarshaller : IMarshaller<IRequest, GetAccessPointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAccessPointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAccessPointRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "GET";
            if (Arn.IsArn(publicRequest.Name))
            {
                publicRequest.AccountId = Amazon.S3Control.Internal.S3ArnUtils.GetAccountIdBasedOnArn(
                    publicRequest.AccountId,
                    Arn.Parse(publicRequest.Name).AccountId
                );
            }
        
            if(publicRequest.IsSetAccountId())
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            if (!publicRequest.IsSetName())
                throw new AmazonS3ControlException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v20180820/accesspoint/{name}";
            request.MarshallerVersion = 2;



            var hostPrefixLabels = new
            {
                AccountId = StringUtils.FromString(publicRequest.AccountId),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.AccountId))
                throw new AmazonS3ControlException("AccountId can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.AccountId}.";
            return request;
        }
        private static GetAccessPointRequestMarshaller _instance = new GetAccessPointRequestMarshaller();        

        internal static GetAccessPointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAccessPointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}