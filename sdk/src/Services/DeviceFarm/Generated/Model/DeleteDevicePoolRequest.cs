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
    /// Container for the parameters to the DeleteDevicePool operation.
    /// Deletes a device pool given the pool ARN. Does not allow deletion of curated pools
    /// owned by the system.
    /// </summary>
    public partial class DeleteDevicePoolRequest : AmazonDeviceFarmRequest
    {
        private string _arn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Represents the Amazon Resource Name (ARN) of the Device Farm device pool to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

    }
}