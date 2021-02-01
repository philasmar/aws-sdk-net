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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of CancelSpotInstanceRequests.
    /// </summary>
    public partial class CancelSpotInstanceRequestsResponse : AmazonWebServiceResponse
    {
        private List<CancelledSpotInstanceRequest> _cancelledSpotInstanceRequests = new List<CancelledSpotInstanceRequest>();

        /// <summary>
        /// Gets and sets the property CancelledSpotInstanceRequests. 
        /// <para>
        /// One or more Spot Instance requests.
        /// </para>
        /// </summary>
        public List<CancelledSpotInstanceRequest> CancelledSpotInstanceRequests
        {
            get { return this._cancelledSpotInstanceRequests; }
            set { this._cancelledSpotInstanceRequests = value; }
        }

        // Check to see if CancelledSpotInstanceRequests property is set
        internal bool IsSetCancelledSpotInstanceRequests()
        {
            return this._cancelledSpotInstanceRequests != null && this._cancelledSpotInstanceRequests.Count > 0; 
        }

    }
}