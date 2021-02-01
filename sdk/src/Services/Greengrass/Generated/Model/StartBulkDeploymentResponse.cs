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
    /// This is the response object from the StartBulkDeployment operation.
    /// </summary>
    public partial class StartBulkDeploymentResponse : AmazonWebServiceResponse
    {
        private string _bulkDeploymentArn;
        private string _bulkDeploymentId;

        /// <summary>
        /// Gets and sets the property BulkDeploymentArn. The ARN of the bulk deployment.
        /// </summary>
        public string BulkDeploymentArn
        {
            get { return this._bulkDeploymentArn; }
            set { this._bulkDeploymentArn = value; }
        }

        // Check to see if BulkDeploymentArn property is set
        internal bool IsSetBulkDeploymentArn()
        {
            return this._bulkDeploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property BulkDeploymentId. The ID of the bulk deployment.
        /// </summary>
        public string BulkDeploymentId
        {
            get { return this._bulkDeploymentId; }
            set { this._bulkDeploymentId = value; }
        }

        // Check to see if BulkDeploymentId property is set
        internal bool IsSetBulkDeploymentId()
        {
            return this._bulkDeploymentId != null;
        }

    }
}