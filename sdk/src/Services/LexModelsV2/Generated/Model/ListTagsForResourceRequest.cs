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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Gets a list of tags associated with a resource. Only bots, bot aliases, and bot channels
    /// can have tags associated with them.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonLexModelsV2Request
    {
        private string _resourcearn;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to get a list of tags for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceARN
        {
            get { return this._resourcearn; }
            set { this._resourcearn = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourcearn != null;
        }

    }
}