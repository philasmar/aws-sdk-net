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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the GetComplianceDetail operation.
    /// </summary>
    public partial class GetComplianceDetailResponse : AmazonWebServiceResponse
    {
        private PolicyComplianceDetail _policyComplianceDetail;

        /// <summary>
        /// Gets and sets the property PolicyComplianceDetail. 
        /// <para>
        /// Information about the resources and the policy that you specified in the <code>GetComplianceDetail</code>
        /// request.
        /// </para>
        /// </summary>
        public PolicyComplianceDetail PolicyComplianceDetail
        {
            get { return this._policyComplianceDetail; }
            set { this._policyComplianceDetail = value; }
        }

        // Check to see if PolicyComplianceDetail property is set
        internal bool IsSetPolicyComplianceDetail()
        {
            return this._policyComplianceDetail != null;
        }

    }
}