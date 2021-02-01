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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetLambdaFunctionRecommendations operation.
    /// Returns AWS Lambda function recommendations.
    /// 
    ///  
    /// <para>
    /// AWS Compute Optimizer generates recommendations for functions that meet a specific
    /// set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
    /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetLambdaFunctionRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = new List<string>();
        private List<LambdaFunctionRecommendationFilter> _filters = new List<LambdaFunctionRecommendationFilter>();
        private List<string> _functionArns = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The IDs of the AWS accounts for which to return function recommendations.
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account of an organization, use this parameter to
        /// specify the member accounts for which you want to return function recommendations.
        /// </para>
        ///  
        /// <para>
        /// Only one account ID can be specified per request.
        /// </para>
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of objects that describe a filter that returns a more specific list of function
        /// recommendations.
        /// </para>
        /// </summary>
        public List<LambdaFunctionRecommendationFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FunctionArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the functions for which to return recommendations.
        /// </para>
        ///  
        /// <para>
        /// You can specify a qualified or unqualified ARN. If you specify an unqualified ARN
        /// without a function version suffix, Compute Optimizer will return recommendations for
        /// the latest (<code>$LATEST</code>) version of the function. If you specify a qualified
        /// ARN with a version suffix, Compute Optimizer will return recommendations for the specified
        /// function version. For more information about using function versions, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-versions.html#versioning-versions-using">Using
        /// versions</a> in the <i>AWS Lambda Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<string> FunctionArns
        {
            get { return this._functionArns; }
            set { this._functionArns = value; }
        }

        // Check to see if FunctionArns property is set
        internal bool IsSetFunctionArns()
        {
            return this._functionArns != null && this._functionArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of function recommendations to return with a single request.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another request with the returned <code>NextToken</code>
        /// value.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to advance to the next page of function recommendations.
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

    }
}