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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoggingOptions Marshaller
    /// </summary>       
    public class LoggingOptionsMarshaller : IRequestMarshaller<LoggingOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoggingOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDetectorDebugOptions())
            {
                context.Writer.WritePropertyName("detectorDebugOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDetectorDebugOptionsListValue in requestObject.DetectorDebugOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DetectorDebugOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDetectorDebugOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetLevel())
            {
                context.Writer.WritePropertyName("level");
                context.Writer.Write(requestObject.Level);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LoggingOptionsMarshaller Instance = new LoggingOptionsMarshaller();

    }
}