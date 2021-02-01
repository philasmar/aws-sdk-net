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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The individual sentiment responses for the utterance.
    /// </summary>
    public partial class SentimentScore
    {
        private double? _mixed;
        private double? _negative;
        private double? _neutral;
        private double? _positive;

        /// <summary>
        /// Gets and sets the property Mixed. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <code>MIXED</code> sentiment.
        /// </para>
        /// </summary>
        public double Mixed
        {
            get { return this._mixed.GetValueOrDefault(); }
            set { this._mixed = value; }
        }

        // Check to see if Mixed property is set
        internal bool IsSetMixed()
        {
            return this._mixed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Negative. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <code>NEGATIVE</code> sentiment.
        /// </para>
        /// </summary>
        public double Negative
        {
            get { return this._negative.GetValueOrDefault(); }
            set { this._negative = value; }
        }

        // Check to see if Negative property is set
        internal bool IsSetNegative()
        {
            return this._negative.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Neutral. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <code>NEUTRAL</code> sentiment.
        /// </para>
        /// </summary>
        public double Neutral
        {
            get { return this._neutral.GetValueOrDefault(); }
            set { this._neutral = value; }
        }

        // Check to see if Neutral property is set
        internal bool IsSetNeutral()
        {
            return this._neutral.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Positive. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <code>POSITIVE</code> sentiment.
        /// </para>
        /// </summary>
        public double Positive
        {
            get { return this._positive.GetValueOrDefault(); }
            set { this._positive = value; }
        }

        // Check to see if Positive property is set
        internal bool IsSetPositive()
        {
            return this._positive.HasValue; 
        }

    }
}