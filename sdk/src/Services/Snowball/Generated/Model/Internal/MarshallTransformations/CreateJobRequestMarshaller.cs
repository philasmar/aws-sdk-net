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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Snowball");
            string target = "AWSIESnowballJobManagementService.CreateJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddressId())
                {
                    context.Writer.WritePropertyName("AddressId");
                    context.Writer.Write(publicRequest.AddressId);
                }

                if(publicRequest.IsSetClusterId())
                {
                    context.Writer.WritePropertyName("ClusterId");
                    context.Writer.Write(publicRequest.ClusterId);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDeviceConfiguration())
                {
                    context.Writer.WritePropertyName("DeviceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetForwardingAddressId())
                {
                    context.Writer.WritePropertyName("ForwardingAddressId");
                    context.Writer.Write(publicRequest.ForwardingAddressId);
                }

                if(publicRequest.IsSetJobType())
                {
                    context.Writer.WritePropertyName("JobType");
                    context.Writer.Write(publicRequest.JobType);
                }

                if(publicRequest.IsSetKmsKeyARN())
                {
                    context.Writer.WritePropertyName("KmsKeyARN");
                    context.Writer.Write(publicRequest.KmsKeyARN);
                }

                if(publicRequest.IsSetNotification())
                {
                    context.Writer.WritePropertyName("Notification");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Notification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResources())
                {
                    context.Writer.WritePropertyName("Resources");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Resources, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleARN())
                {
                    context.Writer.WritePropertyName("RoleARN");
                    context.Writer.Write(publicRequest.RoleARN);
                }

                if(publicRequest.IsSetShippingOption())
                {
                    context.Writer.WritePropertyName("ShippingOption");
                    context.Writer.Write(publicRequest.ShippingOption);
                }

                if(publicRequest.IsSetSnowballCapacityPreference())
                {
                    context.Writer.WritePropertyName("SnowballCapacityPreference");
                    context.Writer.Write(publicRequest.SnowballCapacityPreference);
                }

                if(publicRequest.IsSetSnowballType())
                {
                    context.Writer.WritePropertyName("SnowballType");
                    context.Writer.Write(publicRequest.SnowballType);
                }

                if(publicRequest.IsSetTaxDocuments())
                {
                    context.Writer.WritePropertyName("TaxDocuments");
                    context.Writer.WriteObjectStart();

                    var marshaller = TaxDocumentsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaxDocuments, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}