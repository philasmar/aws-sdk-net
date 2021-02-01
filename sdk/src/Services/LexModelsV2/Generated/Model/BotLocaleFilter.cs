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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Filters responses returned by the <code>ListBotLocales</code> operation.
    /// </summary>
    public partial class BotLocaleFilter
    {
        private BotLocaleFilterName _name;
        private BotLocaleFilterOperator _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field to filter the list of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BotLocaleFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use for the filter. Specify <code>EQ</code> when the <code>ListBotLocales</code>
        /// operation should return only aliases that equal the specified value. Specify <code>CO</code>
        /// when the <code>ListBotLocales</code> operation should return aliases that contain
        /// the specified value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BotLocaleFilterOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value to use for filtering the list of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}