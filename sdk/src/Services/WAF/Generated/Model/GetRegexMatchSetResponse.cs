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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the GetRegexMatchSet operation.
    /// </summary>
    public partial class GetRegexMatchSetResponse : AmazonWebServiceResponse
    {
        private RegexMatchSet _regexMatchSet;

        /// <summary>
        /// Gets and sets the property RegexMatchSet. 
        /// <para>
        /// Information about the <a>RegexMatchSet</a> that you specified in the <code>GetRegexMatchSet</code>
        /// request. For more information, see <a>RegexMatchTuple</a>.
        /// </para>
        /// </summary>
        public RegexMatchSet RegexMatchSet
        {
            get { return this._regexMatchSet; }
            set { this._regexMatchSet = value; }
        }

        // Check to see if RegexMatchSet property is set
        internal bool IsSetRegexMatchSet()
        {
            return this._regexMatchSet != null;
        }

    }
}