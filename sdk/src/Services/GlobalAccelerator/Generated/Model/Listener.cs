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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for a listener.
    /// </summary>
    public partial class Listener
    {
        private ClientAffinity _clientAffinity;
        private string _listenerArn;
        private List<PortRange> _portRanges = new List<PortRange>();
        private Protocol _protocol;

        /// <summary>
        /// Gets and sets the property ClientAffinity. 
        /// <para>
        /// Client affinity lets you direct all requests from a user to the same endpoint, if
        /// you have stateful applications, regardless of the port and protocol of the client
        /// request. Client affinity gives you control over whether to always route each client
        /// to the same specific endpoint.
        /// </para>
        ///  
        /// <para>
        /// AWS Global Accelerator uses a consistent-flow hashing algorithm to choose the optimal
        /// endpoint for a connection. If client affinity is <code>NONE</code>, Global Accelerator
        /// uses the "five-tuple" (5-tuple) properties—source IP address, source port, destination
        /// IP address, destination port, and protocol—to select the hash value, and then chooses
        /// the best endpoint. However, with this setting, if someone uses different ports to
        /// connect to Global Accelerator, their connections might not be always routed to the
        /// same endpoint because the hash value changes. 
        /// </para>
        ///  
        /// <para>
        /// If you want a given client to always be routed to the same endpoint, set client affinity
        /// to <code>SOURCE_IP</code> instead. When you use the <code>SOURCE_IP</code> setting,
        /// Global Accelerator uses the "two-tuple" (2-tuple) properties— source (client) IP address
        /// and destination IP address—to select the hash value.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>NONE</code>.
        /// </para>
        /// </summary>
        public ClientAffinity ClientAffinity
        {
            get { return this._clientAffinity; }
            set { this._clientAffinity = value; }
        }

        // Check to see if ClientAffinity property is set
        internal bool IsSetClientAffinity()
        {
            return this._clientAffinity != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The list of port ranges for the connections from clients to the accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PortRange> PortRanges
        {
            get { return this._portRanges; }
            set { this._portRanges = value; }
        }

        // Check to see if PortRanges property is set
        internal bool IsSetPortRanges()
        {
            return this._portRanges != null && this._portRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for the connections from clients to the accelerator.
        /// </para>
        /// </summary>
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}