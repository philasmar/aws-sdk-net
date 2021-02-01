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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the GetBuiltinSlotTypes operation.
    /// </summary>
    public partial class GetBuiltinSlotTypesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<BuiltinSlotTypeMetadata> _slotTypes = new List<BuiltinSlotTypeMetadata>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, the response includes a pagination token that you can
        /// use in your next request to fetch the next page of slot types.
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
        /// Gets and sets the property SlotTypes. 
        /// <para>
        /// An array of <code>BuiltInSlotTypeMetadata</code> objects, one entry for each slot
        /// type returned.
        /// </para>
        /// </summary>
        public List<BuiltinSlotTypeMetadata> SlotTypes
        {
            get { return this._slotTypes; }
            set { this._slotTypes = value; }
        }

        // Check to see if SlotTypes property is set
        internal bool IsSetSlotTypes()
        {
            return this._slotTypes != null && this._slotTypes.Count > 0; 
        }

    }
}