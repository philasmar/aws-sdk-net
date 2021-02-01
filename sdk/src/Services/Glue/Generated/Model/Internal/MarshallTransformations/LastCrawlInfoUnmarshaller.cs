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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LastCrawlInfo Object
    /// </summary>  
    public class LastCrawlInfoUnmarshaller : IUnmarshaller<LastCrawlInfo, XmlUnmarshallerContext>, IUnmarshaller<LastCrawlInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LastCrawlInfo IUnmarshaller<LastCrawlInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LastCrawlInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LastCrawlInfo unmarshalledObject = new LastCrawlInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogStream", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogStream = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MessagePrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessagePrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LastCrawlInfoUnmarshaller _instance = new LastCrawlInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LastCrawlInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}