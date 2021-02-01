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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Paginator for the DescribeInstances operation
    ///</summary>
    public interface IDescribeInstancesPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<DescribeInstancesResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the Reservations
        /// </summary>
        IPaginatedEnumerable<Reservation> Reservations { get; }
    }
}
#endif