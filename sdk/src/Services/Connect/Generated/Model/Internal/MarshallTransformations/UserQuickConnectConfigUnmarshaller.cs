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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserQuickConnectConfig Object
    /// </summary>  
    public class UserQuickConnectConfigUnmarshaller : IUnmarshaller<UserQuickConnectConfig, XmlUnmarshallerContext>, IUnmarshaller<UserQuickConnectConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserQuickConnectConfig IUnmarshaller<UserQuickConnectConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserQuickConnectConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UserQuickConnectConfig unmarshalledObject = new UserQuickConnectConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContactFlowId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactFlowId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserQuickConnectConfigUnmarshaller _instance = new UserQuickConnectConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserQuickConnectConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}