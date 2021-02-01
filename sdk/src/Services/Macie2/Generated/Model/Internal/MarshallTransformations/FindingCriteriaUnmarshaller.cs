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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FindingCriteria Object
    /// </summary>  
    public class FindingCriteriaUnmarshaller : IUnmarshaller<FindingCriteria, XmlUnmarshallerContext>, IUnmarshaller<FindingCriteria, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FindingCriteria IUnmarshaller<FindingCriteria, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FindingCriteria Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FindingCriteria unmarshalledObject = new FindingCriteria();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("criterion", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, CriterionAdditionalProperties, StringUnmarshaller, CriterionAdditionalPropertiesUnmarshaller>(StringUnmarshaller.Instance, CriterionAdditionalPropertiesUnmarshaller.Instance);
                    unmarshalledObject.Criterion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FindingCriteriaUnmarshaller _instance = new FindingCriteriaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingCriteriaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}