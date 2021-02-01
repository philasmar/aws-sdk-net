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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetReportGroups operation.
    /// </summary>
    public partial class BatchGetReportGroupsResponse : AmazonWebServiceResponse
    {
        private List<ReportGroup> _reportGroups = new List<ReportGroup>();
        private List<string> _reportGroupsNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property ReportGroups. 
        /// <para>
        ///  The array of report groups returned by <code>BatchGetReportGroups</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ReportGroup> ReportGroups
        {
            get { return this._reportGroups; }
            set { this._reportGroups = value; }
        }

        // Check to see if ReportGroups property is set
        internal bool IsSetReportGroups()
        {
            return this._reportGroups != null && this._reportGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReportGroupsNotFound. 
        /// <para>
        ///  An array of ARNs passed to <code>BatchGetReportGroups</code> that are not associated
        /// with a <code>ReportGroup</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ReportGroupsNotFound
        {
            get { return this._reportGroupsNotFound; }
            set { this._reportGroupsNotFound = value; }
        }

        // Check to see if ReportGroupsNotFound property is set
        internal bool IsSetReportGroupsNotFound()
        {
            return this._reportGroupsNotFound != null && this._reportGroupsNotFound.Count > 0; 
        }

    }
}