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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDedicatedIpPool operation.
    /// Delete a dedicated IP pool.
    /// </summary>
    public partial class DeleteDedicatedIpPoolRequest : AmazonPinpointEmailRequest
    {
        private string _poolName;

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the dedicated IP pool that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

    }
}