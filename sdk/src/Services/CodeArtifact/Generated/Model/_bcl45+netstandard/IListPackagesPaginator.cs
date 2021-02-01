#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using Amazon.Runtime;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Paginator for the ListPackages operation
    ///</summary>
    public interface IListPackagesPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<ListPackagesResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the Packages
        /// </summary>
        IPaginatedEnumerable<PackageSummary> Packages { get; }
    }
}
#endif