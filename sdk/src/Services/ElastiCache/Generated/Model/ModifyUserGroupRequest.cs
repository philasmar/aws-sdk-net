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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyUserGroup operation.
    /// Changes the list of users that belong to the user group.
    /// </summary>
    public partial class ModifyUserGroupRequest : AmazonElastiCacheRequest
    {
        private string _userGroupId;
        private List<string> _userIdsToAdd = new List<string>();
        private List<string> _userIdsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The ID of the user group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserGroupId
        {
            get { return this._userGroupId; }
            set { this._userGroupId = value; }
        }

        // Check to see if UserGroupId property is set
        internal bool IsSetUserGroupId()
        {
            return this._userGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdsToAdd. 
        /// <para>
        /// The list of user IDs to add to the user group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> UserIdsToAdd
        {
            get { return this._userIdsToAdd; }
            set { this._userIdsToAdd = value; }
        }

        // Check to see if UserIdsToAdd property is set
        internal bool IsSetUserIdsToAdd()
        {
            return this._userIdsToAdd != null && this._userIdsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserIdsToRemove. 
        /// <para>
        /// The list of user IDs to remove from the user group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> UserIdsToRemove
        {
            get { return this._userIdsToRemove; }
            set { this._userIdsToRemove = value; }
        }

        // Check to see if UserIdsToRemove property is set
        internal bool IsSetUserIdsToRemove()
        {
            return this._userIdsToRemove != null && this._userIdsToRemove.Count > 0; 
        }

    }
}