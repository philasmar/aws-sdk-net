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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the ListFirewalls operation.
    /// </summary>
    public partial class ListFirewallsResponse : AmazonWebServiceResponse
    {
        private List<FirewallMetadata> _firewalls = new List<FirewallMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Firewalls. 
        /// <para>
        /// The firewall metadata objects for the VPCs that you specified. Depending on your setting
        /// for max results and the number of firewalls you have, a single call might not be the
        /// full list. 
        /// </para>
        /// </summary>
        public List<FirewallMetadata> Firewalls
        {
            get { return this._firewalls; }
            set { this._firewalls = value; }
        }

        // Check to see if Firewalls property is set
        internal bool IsSetFirewalls()
        {
            return this._firewalls != null && this._firewalls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request a list of objects with a <code>MaxResults</code> setting, if the
        /// number of objects that are still available for retrieval exceeds the maximum you requested,
        /// Network Firewall returns a <code>NextToken</code> value in the response. To retrieve
        /// the next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}