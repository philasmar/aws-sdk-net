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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// This is the response object from the ListDatasets operation.
    /// </summary>
    public partial class ListDatasetsResponse : AmazonWebServiceResponse
    {
        private List<DatasetSummary> _datasetSummaries = new List<DatasetSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DatasetSummaries. 
        /// <para>
        /// A list of <code>DatasetSummary</code> objects.
        /// </para>
        /// </summary>
        public List<DatasetSummary> DatasetSummaries
        {
            get { return this._datasetSummaries; }
            set { this._datasetSummaries = value; }
        }

        // Check to see if DatasetSummaries property is set
        internal bool IsSetDatasetSummaries()
        {
            return this._datasetSummaries != null && this._datasetSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results, or <code>null</code> if there are no
        /// more results.
        /// </para>
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

    }
}