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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrafficMirrorSession Object
    /// </summary>  
    public class TrafficMirrorSessionUnmarshaller : IUnmarshaller<TrafficMirrorSession, XmlUnmarshallerContext>, IUnmarshaller<TrafficMirrorSession, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TrafficMirrorSession Unmarshall(XmlUnmarshallerContext context)
        {
            TrafficMirrorSession unmarshalledObject = new TrafficMirrorSession();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("packetLength", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.PacketLength = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sessionNumber", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SessionNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("trafficMirrorFilterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficMirrorFilterId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trafficMirrorSessionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficMirrorSessionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trafficMirrorTargetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficMirrorTargetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("virtualNetworkId", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.VirtualNetworkId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TrafficMirrorSession Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static TrafficMirrorSessionUnmarshaller _instance = new TrafficMirrorSessionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrafficMirrorSessionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}