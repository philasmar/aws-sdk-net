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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartNotebookExecution Request Marshaller
    /// </summary>       
    public class StartNotebookExecutionRequestMarshaller : IMarshaller<IRequest, StartNotebookExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartNotebookExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartNotebookExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.StartNotebookExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2009-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEditorId())
                {
                    context.Writer.WritePropertyName("EditorId");
                    context.Writer.Write(publicRequest.EditorId);
                }

                if(publicRequest.IsSetExecutionEngine())
                {
                    context.Writer.WritePropertyName("ExecutionEngine");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExecutionEngineConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExecutionEngine, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNotebookExecutionName())
                {
                    context.Writer.WritePropertyName("NotebookExecutionName");
                    context.Writer.Write(publicRequest.NotebookExecutionName);
                }

                if(publicRequest.IsSetNotebookInstanceSecurityGroupId())
                {
                    context.Writer.WritePropertyName("NotebookInstanceSecurityGroupId");
                    context.Writer.Write(publicRequest.NotebookInstanceSecurityGroupId);
                }

                if(publicRequest.IsSetNotebookParams())
                {
                    context.Writer.WritePropertyName("NotebookParams");
                    context.Writer.Write(publicRequest.NotebookParams);
                }

                if(publicRequest.IsSetRelativePath())
                {
                    context.Writer.WritePropertyName("RelativePath");
                    context.Writer.Write(publicRequest.RelativePath);
                }

                if(publicRequest.IsSetServiceRole())
                {
                    context.Writer.WritePropertyName("ServiceRole");
                    context.Writer.Write(publicRequest.ServiceRole);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartNotebookExecutionRequestMarshaller _instance = new StartNotebookExecutionRequestMarshaller();        

        internal static StartNotebookExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartNotebookExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}