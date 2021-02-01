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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSolution operation.
    /// Deletes all versions of a solution and the <code>Solution</code> object itself. Before
    /// deleting a solution, you must delete all campaigns based on the solution. To determine
    /// what campaigns are using the solution, call <a>ListCampaigns</a> and supply the Amazon
    /// Resource Name (ARN) of the solution. You can't delete a solution if an associated
    /// <code>SolutionVersion</code> is in the CREATE PENDING or IN PROGRESS state. For more
    /// information on solutions, see <a>CreateSolution</a>.
    /// </summary>
    public partial class DeleteSolutionRequest : AmazonPersonalizeRequest
    {
        private string _solutionArn;

        /// <summary>
        /// Gets and sets the property SolutionArn. 
        /// <para>
        /// The ARN of the solution to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SolutionArn
        {
            get { return this._solutionArn; }
            set { this._solutionArn = value; }
        }

        // Check to see if SolutionArn property is set
        internal bool IsSetSolutionArn()
        {
            return this._solutionArn != null;
        }

    }
}