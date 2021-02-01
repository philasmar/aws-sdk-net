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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReportExportConfig Marshaller
    /// </summary>       
    public class ReportExportConfigMarshaller : IRequestMarshaller<ReportExportConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReportExportConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExportConfigType())
            {
                context.Writer.WritePropertyName("exportConfigType");
                context.Writer.Write(requestObject.ExportConfigType);
            }

            if(requestObject.IsSetS3Destination())
            {
                context.Writer.WritePropertyName("s3Destination");
                context.Writer.WriteObjectStart();

                var marshaller = S3ReportExportConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Destination, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ReportExportConfigMarshaller Instance = new ReportExportConfigMarshaller();

    }
}