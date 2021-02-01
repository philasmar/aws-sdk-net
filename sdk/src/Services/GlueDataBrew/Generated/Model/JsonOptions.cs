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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents the JSON-specific options that define how input is to be interpreted by
    /// AWS Glue DataBrew.
    /// </summary>
    public partial class JsonOptions
    {
        private bool? _multiLine;

        /// <summary>
        /// Gets and sets the property MultiLine. 
        /// <para>
        /// A value that specifies whether JSON input contains embedded new line characters.
        /// </para>
        /// </summary>
        public bool MultiLine
        {
            get { return this._multiLine.GetValueOrDefault(); }
            set { this._multiLine = value; }
        }

        // Check to see if MultiLine property is set
        internal bool IsSetMultiLine()
        {
            return this._multiLine.HasValue; 
        }

    }
}