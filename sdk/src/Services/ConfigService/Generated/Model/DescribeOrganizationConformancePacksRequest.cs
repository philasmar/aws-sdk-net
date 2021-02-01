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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganizationConformancePacks operation.
    /// Returns a list of organization conformance packs. 
    /// 
    ///  <note> 
    /// <para>
    /// When you specify the limit and the next token, you receive a paginated response. 
    /// </para>
    ///  
    /// <para>
    /// Limit and next token are not applicable if you specify organization conformance packs
    /// names. They are only applicable, when you request all the organization conformance
    /// packs. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeOrganizationConformancePacksRequest : AmazonConfigServiceRequest
    {
        private int? _limit;
        private string _nextToken;
        private List<string> _organizationConformancePackNames = new List<string>();

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of organization config packs returned on each page. If you do no
        /// specify a number, AWS Config uses the default. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string returned on a previous page that you use to get the next page
        /// of results in a paginated response.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackNames. 
        /// <para>
        /// The name that you assign to an organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> OrganizationConformancePackNames
        {
            get { return this._organizationConformancePackNames; }
            set { this._organizationConformancePackNames = value; }
        }

        // Check to see if OrganizationConformancePackNames property is set
        internal bool IsSetOrganizationConformancePackNames()
        {
            return this._organizationConformancePackNames != null && this._organizationConformancePackNames.Count > 0; 
        }

    }
}