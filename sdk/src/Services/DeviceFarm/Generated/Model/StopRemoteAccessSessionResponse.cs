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
    /// Represents the response from the server that describes the remote access session when
    /// AWS Device Farm stops the session.
    /// </summary>
    public partial class StopRemoteAccessSessionResponse : AmazonWebServiceResponse
    {
        private RemoteAccessSession _remoteAccessSession;

        /// <summary>
        /// Gets and sets the property RemoteAccessSession. 
        /// <para>
        /// A container that represents the metadata from the service about the remote access
        /// session you are stopping.
        /// </para>
        /// </summary>
        public RemoteAccessSession RemoteAccessSession
        {
            get { return this._remoteAccessSession; }
            set { this._remoteAccessSession = value; }
        }

        // Check to see if RemoteAccessSession property is set
        internal bool IsSetRemoteAccessSession()
        {
            return this._remoteAccessSession != null;
        }

    }
}