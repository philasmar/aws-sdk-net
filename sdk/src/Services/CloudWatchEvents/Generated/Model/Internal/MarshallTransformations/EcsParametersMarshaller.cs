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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EcsParameters Marshaller
    /// </summary>       
    public class EcsParametersMarshaller : IRequestMarshaller<EcsParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EcsParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("Group");
                context.Writer.Write(requestObject.Group);
            }

            if(requestObject.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("LaunchType");
                context.Writer.Write(requestObject.LaunchType);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("PlatformVersion");
                context.Writer.Write(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetTaskCount())
            {
                context.Writer.WritePropertyName("TaskCount");
                context.Writer.Write(requestObject.TaskCount);
            }

            if(requestObject.IsSetTaskDefinitionArn())
            {
                context.Writer.WritePropertyName("TaskDefinitionArn");
                context.Writer.Write(requestObject.TaskDefinitionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EcsParametersMarshaller Instance = new EcsParametersMarshaller();

    }
}