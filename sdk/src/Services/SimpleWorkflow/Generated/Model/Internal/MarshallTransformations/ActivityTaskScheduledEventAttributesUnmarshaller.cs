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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActivityTaskScheduledEventAttributes Object
    /// </summary>  
    public class ActivityTaskScheduledEventAttributesUnmarshaller : IUnmarshaller<ActivityTaskScheduledEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ActivityTaskScheduledEventAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActivityTaskScheduledEventAttributes IUnmarshaller<ActivityTaskScheduledEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActivityTaskScheduledEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActivityTaskScheduledEventAttributes unmarshalledObject = new ActivityTaskScheduledEventAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activityId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActivityId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("activityType", targetDepth))
                {
                    var unmarshaller = ActivityTypeUnmarshaller.Instance;
                    unmarshalledObject.ActivityType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("control", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Control = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskCompletedEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("heartbeatTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HeartbeatTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scheduleToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scheduleToStartTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleToStartTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskList", targetDepth))
                {
                    var unmarshaller = TaskListUnmarshaller.Instance;
                    unmarshalledObject.TaskList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskPriority", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskPriority = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActivityTaskScheduledEventAttributesUnmarshaller _instance = new ActivityTaskScheduledEventAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivityTaskScheduledEventAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}