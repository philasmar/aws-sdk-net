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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetVaultNotifications Request Marshaller
    /// </summary>       
    public class SetVaultNotificationsRequestMarshaller : IMarshaller<IRequest, SetVaultNotificationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetVaultNotificationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetVaultNotificationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-06-01";            
            request.HttpMethod = "PUT";

            request.AddPathResource("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromString(publicRequest.AccountId) : string.Empty);
            if (!publicRequest.IsSetVaultName())
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            request.AddPathResource("{vaultName}", StringUtils.FromString(publicRequest.VaultName));
            request.ResourcePath = "/{accountId}/vaults/{vaultName}/notification-configuration";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                var context = new JsonMarshallerContext(request, writer);
                context.Writer.WriteObjectStart();

                var marshaller = VaultNotificationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VaultNotificationConfig, context);

                context.Writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SetVaultNotificationsRequestMarshaller _instance = new SetVaultNotificationsRequestMarshaller();        

        internal static SetVaultNotificationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetVaultNotificationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}