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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FacetResult Object
    /// </summary>  
    public class FacetResultUnmarshaller : IUnmarshaller<FacetResult, XmlUnmarshallerContext>, IUnmarshaller<FacetResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FacetResult IUnmarshaller<FacetResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FacetResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FacetResult unmarshalledObject = new FacetResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DocumentAttributeKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentAttributeKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentAttributeValueCountPairs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DocumentAttributeValueCountPair, DocumentAttributeValueCountPairUnmarshaller>(DocumentAttributeValueCountPairUnmarshaller.Instance);
                    unmarshalledObject.DocumentAttributeValueCountPairs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentAttributeValueType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentAttributeValueType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FacetResultUnmarshaller _instance = new FacetResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FacetResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}