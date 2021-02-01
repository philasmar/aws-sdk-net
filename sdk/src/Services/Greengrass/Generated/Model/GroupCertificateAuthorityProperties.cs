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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about a certificate authority for a group.
    /// </summary>
    public partial class GroupCertificateAuthorityProperties
    {
        private string _groupCertificateAuthorityArn;
        private string _groupCertificateAuthorityId;

        /// <summary>
        /// Gets and sets the property GroupCertificateAuthorityArn. The ARN of the certificate
        /// authority for the group.
        /// </summary>
        public string GroupCertificateAuthorityArn
        {
            get { return this._groupCertificateAuthorityArn; }
            set { this._groupCertificateAuthorityArn = value; }
        }

        // Check to see if GroupCertificateAuthorityArn property is set
        internal bool IsSetGroupCertificateAuthorityArn()
        {
            return this._groupCertificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property GroupCertificateAuthorityId. The ID of the certificate
        /// authority for the group.
        /// </summary>
        public string GroupCertificateAuthorityId
        {
            get { return this._groupCertificateAuthorityId; }
            set { this._groupCertificateAuthorityId = value; }
        }

        // Check to see if GroupCertificateAuthorityId property is set
        internal bool IsSetGroupCertificateAuthorityId()
        {
            return this._groupCertificateAuthorityId != null;
        }

    }
}