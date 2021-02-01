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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for a <a>DescribeStacks</a> action.
    /// </summary>
    public partial class DescribeStacksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Stack> _stacks = new List<Stack>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the output exceeds 1 MB in size, a string that identifies the next page of stacks.
        /// If no additional page exists, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Stacks. 
        /// <para>
        /// A list of stack structures.
        /// </para>
        /// </summary>
        public List<Stack> Stacks
        {
            get { return this._stacks; }
            set { this._stacks = value; }
        }

        // Check to see if Stacks property is set
        internal bool IsSetStacks()
        {
            return this._stacks != null && this._stacks.Count > 0; 
        }

    }
}