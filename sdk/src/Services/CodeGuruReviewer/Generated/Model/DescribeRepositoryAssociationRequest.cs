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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRepositoryAssociation operation.
    /// Returns a <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">
    /// <code>RepositoryAssociation</code> </a> object that contains information about the
    /// requested repository association.
    /// </summary>
    public partial class DescribeRepositoryAssociationRequest : AmazonCodeGuruReviewerRequest
    {
        private string _associationArn;

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">
        /// <code>RepositoryAssociation</code> </a> object. You can retrieve this ARN by calling
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_ListRepositoryAssociations.html">
        /// <code>ListRepositoryAssociations</code> </a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AssociationArn
        {
            get { return this._associationArn; }
            set { this._associationArn = value; }
        }

        // Check to see if AssociationArn property is set
        internal bool IsSetAssociationArn()
        {
            return this._associationArn != null;
        }

    }
}