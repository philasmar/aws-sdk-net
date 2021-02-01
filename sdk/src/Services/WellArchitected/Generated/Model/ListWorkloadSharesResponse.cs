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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Input for List Workload Share
    /// </summary>
    public partial class ListWorkloadSharesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _workloadId;
        private List<WorkloadShareSummary> _workloadShareSummaries = new List<WorkloadShareSummary>();

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
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
        /// Gets and sets the property WorkloadId.
        /// </summary>
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadShareSummaries.
        /// </summary>
        public List<WorkloadShareSummary> WorkloadShareSummaries
        {
            get { return this._workloadShareSummaries; }
            set { this._workloadShareSummaries = value; }
        }

        // Check to see if WorkloadShareSummaries property is set
        internal bool IsSetWorkloadShareSummaries()
        {
            return this._workloadShareSummaries != null && this._workloadShareSummaries.Count > 0; 
        }

    }
}