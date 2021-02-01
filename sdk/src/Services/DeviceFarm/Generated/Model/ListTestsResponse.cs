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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the result of a list tests request.
    /// </summary>
    public partial class ListTestsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Test> _tests = new List<Test>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the number of items that are returned is significantly large, this is an identifier
        /// that is also returned. It can be used in a subsequent call to this operation to return
        /// the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tests. 
        /// <para>
        /// Information about the tests.
        /// </para>
        /// </summary>
        public List<Test> Tests
        {
            get { return this._tests; }
            set { this._tests = value; }
        }

        // Check to see if Tests property is set
        internal bool IsSetTests()
        {
            return this._tests != null && this._tests.Count > 0; 
        }

    }
}