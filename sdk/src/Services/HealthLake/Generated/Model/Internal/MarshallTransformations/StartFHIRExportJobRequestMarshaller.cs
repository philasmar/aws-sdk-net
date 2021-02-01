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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.HealthLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.HealthLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartFHIRExportJob Request Marshaller
    /// </summary>       
    public class StartFHIRExportJobRequestMarshaller : IMarshaller<IRequest, StartFHIRExportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartFHIRExportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartFHIRExportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.HealthLake");
            string target = "HealthLake.StartFHIRExportJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WritePropertyName("DataAccessRoleArn");
                    context.Writer.Write(publicRequest.DataAccessRoleArn);
                }

                if(publicRequest.IsSetDatastoreId())
                {
                    context.Writer.WritePropertyName("DatastoreId");
                    context.Writer.Write(publicRequest.DatastoreId);
                }

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("JobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("OutputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartFHIRExportJobRequestMarshaller _instance = new StartFHIRExportJobRequestMarshaller();        

        internal static StartFHIRExportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartFHIRExportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}