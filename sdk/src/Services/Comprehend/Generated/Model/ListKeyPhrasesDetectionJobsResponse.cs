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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the ListKeyPhrasesDetectionJobs operation.
    /// </summary>
    public partial class ListKeyPhrasesDetectionJobsResponse : AmazonWebServiceResponse
    {
        private List<KeyPhrasesDetectionJobProperties> _keyPhrasesDetectionJobPropertiesList = new List<KeyPhrasesDetectionJobProperties>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property KeyPhrasesDetectionJobPropertiesList. 
        /// <para>
        /// A list containing the properties of each job that is returned.
        /// </para>
        /// </summary>
        public List<KeyPhrasesDetectionJobProperties> KeyPhrasesDetectionJobPropertiesList
        {
            get { return this._keyPhrasesDetectionJobPropertiesList; }
            set { this._keyPhrasesDetectionJobPropertiesList = value; }
        }

        // Check to see if KeyPhrasesDetectionJobPropertiesList property is set
        internal bool IsSetKeyPhrasesDetectionJobPropertiesList()
        {
            return this._keyPhrasesDetectionJobPropertiesList != null && this._keyPhrasesDetectionJobPropertiesList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Identifies the next page of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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