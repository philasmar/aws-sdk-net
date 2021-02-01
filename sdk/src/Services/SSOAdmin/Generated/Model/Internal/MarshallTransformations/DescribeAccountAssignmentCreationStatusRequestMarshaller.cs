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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAccountAssignmentCreationStatus Request Marshaller
    /// </summary>       
    public class DescribeAccountAssignmentCreationStatusRequestMarshaller : IMarshaller<IRequest, DescribeAccountAssignmentCreationStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAccountAssignmentCreationStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAccountAssignmentCreationStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOAdmin");
            string target = "SWBExternalService.DescribeAccountAssignmentCreationStatus";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountAssignmentCreationRequestId())
                {
                    context.Writer.WritePropertyName("AccountAssignmentCreationRequestId");
                    context.Writer.Write(publicRequest.AccountAssignmentCreationRequestId);
                }

                if(publicRequest.IsSetInstanceArn())
                {
                    context.Writer.WritePropertyName("InstanceArn");
                    context.Writer.Write(publicRequest.InstanceArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeAccountAssignmentCreationStatusRequestMarshaller _instance = new DescribeAccountAssignmentCreationStatusRequestMarshaller();        

        internal static DescribeAccountAssignmentCreationStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAccountAssignmentCreationStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}