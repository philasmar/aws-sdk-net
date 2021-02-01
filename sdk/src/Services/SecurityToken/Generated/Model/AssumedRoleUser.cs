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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// The identifiers for the temporary security credentials that the operation returns.
    /// </summary>
    public partial class AssumedRoleUser
    {
        private string _arn;
        private string _assumedRoleId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the temporary security credentials that are returned from the <a>AssumeRole</a>
        /// action. For more information about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property AssumedRoleId. 
        /// <para>
        /// A unique identifier that contains the role ID and the role session name of the role
        /// that is being assumed. The role ID is generated by AWS when the role is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=193)]
        public string AssumedRoleId
        {
            get { return this._assumedRoleId; }
            set { this._assumedRoleId = value; }
        }

        // Check to see if AssumedRoleId property is set
        internal bool IsSetAssumedRoleId()
        {
            return this._assumedRoleId != null;
        }

    }
}