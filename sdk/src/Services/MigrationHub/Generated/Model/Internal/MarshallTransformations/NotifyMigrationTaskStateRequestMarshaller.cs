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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotifyMigrationTaskState Request Marshaller
    /// </summary>       
    public class NotifyMigrationTaskStateRequestMarshaller : IMarshaller<IRequest, NotifyMigrationTaskStateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NotifyMigrationTaskStateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(NotifyMigrationTaskStateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHub");
            string target = "AWSMigrationHub.NotifyMigrationTaskState";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-05-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetMigrationTaskName())
                {
                    context.Writer.WritePropertyName("MigrationTaskName");
                    context.Writer.Write(publicRequest.MigrationTaskName);
                }

                if(publicRequest.IsSetNextUpdateSeconds())
                {
                    context.Writer.WritePropertyName("NextUpdateSeconds");
                    context.Writer.Write(publicRequest.NextUpdateSeconds);
                }

                if(publicRequest.IsSetProgressUpdateStream())
                {
                    context.Writer.WritePropertyName("ProgressUpdateStream");
                    context.Writer.Write(publicRequest.ProgressUpdateStream);
                }

                if(publicRequest.IsSetTask())
                {
                    context.Writer.WritePropertyName("Task");
                    context.Writer.WriteObjectStart();

                    var marshaller = TaskMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Task, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpdateDateTime())
                {
                    context.Writer.WritePropertyName("UpdateDateTime");
                    context.Writer.Write(publicRequest.UpdateDateTime);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static NotifyMigrationTaskStateRequestMarshaller _instance = new NotifyMigrationTaskStateRequestMarshaller();        

        internal static NotifyMigrationTaskStateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotifyMigrationTaskStateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}