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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A contact is the end-user who is receiving the email.
    /// </summary>
    public partial class Contact
    {
        private string _emailAddress;
        private DateTime? _lastUpdatedTimestamp;
        private List<TopicPreference> _topicDefaultPreferences = new List<TopicPreference>();
        private List<TopicPreference> _topicPreferences = new List<TopicPreference>();
        private bool? _unsubscribeAll;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The contact's email address.
        /// </para>
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// A timestamp noting the last time the contact's information was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicDefaultPreferences. 
        /// <para>
        /// The default topic preferences applied to the contact.
        /// </para>
        /// </summary>
        public List<TopicPreference> TopicDefaultPreferences
        {
            get { return this._topicDefaultPreferences; }
            set { this._topicDefaultPreferences = value; }
        }

        // Check to see if TopicDefaultPreferences property is set
        internal bool IsSetTopicDefaultPreferences()
        {
            return this._topicDefaultPreferences != null && this._topicDefaultPreferences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TopicPreferences. 
        /// <para>
        /// The contact's preference for being opted-in to or opted-out of a topic.
        /// </para>
        /// </summary>
        public List<TopicPreference> TopicPreferences
        {
            get { return this._topicPreferences; }
            set { this._topicPreferences = value; }
        }

        // Check to see if TopicPreferences property is set
        internal bool IsSetTopicPreferences()
        {
            return this._topicPreferences != null && this._topicPreferences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnsubscribeAll. 
        /// <para>
        /// A boolean value status noting if the contact is unsubscribed from all contact list
        /// topics.
        /// </para>
        /// </summary>
        public bool UnsubscribeAll
        {
            get { return this._unsubscribeAll.GetValueOrDefault(); }
            set { this._unsubscribeAll = value; }
        }

        // Check to see if UnsubscribeAll property is set
        internal bool IsSetUnsubscribeAll()
        {
            return this._unsubscribeAll.HasValue; 
        }

    }
}