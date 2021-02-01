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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CheckIfPhoneNumberIsOptedOut Request Marshaller
    /// </summary>       
    public class CheckIfPhoneNumberIsOptedOutRequestMarshaller : IMarshaller<IRequest, CheckIfPhoneNumberIsOptedOutRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CheckIfPhoneNumberIsOptedOutRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CheckIfPhoneNumberIsOptedOutRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.Parameters.Add("Action", "CheckIfPhoneNumberIsOptedOut");
            request.Parameters.Add("Version", "2010-03-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetPhoneNumber())
                {
                    request.Parameters.Add("phoneNumber", StringUtils.FromString(publicRequest.PhoneNumber));
                }
            }
            return request;
        }
                    private static CheckIfPhoneNumberIsOptedOutRequestMarshaller _instance = new CheckIfPhoneNumberIsOptedOutRequestMarshaller();        

        internal static CheckIfPhoneNumberIsOptedOutRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CheckIfPhoneNumberIsOptedOutRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}