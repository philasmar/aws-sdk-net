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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Paginators for the AugmentedAIRuntime service
    ///</summary>
    public class AugmentedAIRuntimePaginatorFactory : IAugmentedAIRuntimePaginatorFactory
    {
        private readonly IAmazonAugmentedAIRuntime client;

        internal AugmentedAIRuntimePaginatorFactory(IAmazonAugmentedAIRuntime client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListHumanLoops operation
        ///</summary>
        public IListHumanLoopsPaginator ListHumanLoops(ListHumanLoopsRequest request) 
        {
            return new ListHumanLoopsPaginator(this.client, request);
        }
    }
}
#endif