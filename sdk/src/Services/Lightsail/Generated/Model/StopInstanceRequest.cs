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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the StopInstance operation.
    /// Stops a specific Amazon Lightsail instance that is currently running.
    /// 
    ///  <note> 
    /// <para>
    /// When you start a stopped instance, Lightsail assigns a new public IP address to the
    /// instance. To use the same IP address after stopping and starting an instance, create
    /// a static IP address and attach it to the instance. For more information, see the <a
    /// href="https://lightsail.aws.amazon.com/ls/docs/en/articles/lightsail-create-static-ip">Lightsail
    /// Dev Guide</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>stop instance</code> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <code>instance name</code>. For more information,
    /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class StopInstanceRequest : AmazonLightsailRequest
    {
        private bool? _force;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// When set to <code>True</code>, forces a Lightsail instance that is stuck in a <code>stopping</code>
        /// state to stop.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only use the <code>force</code> parameter if your instance is stuck in the <code>stopping</code>
        /// state. In any other state, your instance should stop normally without adding this
        /// parameter to your API request.
        /// </para>
        ///  </important>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance (a virtual private server) to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}