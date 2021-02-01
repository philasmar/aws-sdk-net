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
 * Do not modify this file. This file is generated from the forecastquery-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastQueryService.Model
{
    /// <summary>
    /// Container for the parameters to the QueryForecast operation.
    /// Retrieves a forecast for a single item, filtered by the supplied criteria.
    /// 
    ///  
    /// <para>
    /// The criteria is a key-value pair. The key is either <code>item_id</code> (or the equivalent
    /// non-timestamp, non-target field) from the <code>TARGET_TIME_SERIES</code> dataset,
    /// or one of the forecast dimensions specified as part of the <code>FeaturizationConfig</code>
    /// object.
    /// </para>
    ///  
    /// <para>
    /// By default, <code>QueryForecast</code> returns the complete date range for the filtered
    /// forecast. You can request a specific date range.
    /// </para>
    ///  
    /// <para>
    /// To get the full forecast, use the <a href="https://docs.aws.amazon.com/en_us/forecast/latest/dg/API_CreateForecastExportJob.html">CreateForecastExportJob</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The forecasts generated by Amazon Forecast are in the same timezone as the dataset
    /// that was used to create the predictor.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class QueryForecastRequest : AmazonForecastQueryServiceRequest
    {
        private string _endDate;
        private Dictionary<string, string> _filters = new Dictionary<string, string>();
        private string _forecastArn;
        private string _nextToken;
        private string _startDate;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date for the forecast. Specify the date using this format: yyyy-MM-dd'T'HH:mm:ss
        /// (ISO 8601 format). For example, 2015-01-01T20:00:00. 
        /// </para>
        /// </summary>
        public string EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filtering criteria to apply when retrieving the forecast. For example, to get
        /// the forecast for <code>client_21</code> in the electricity usage dataset, specify
        /// the following:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"item_id" : "client_21"}</code> 
        /// </para>
        ///  
        /// <para>
        /// To get the full forecast, use the <a href="https://docs.aws.amazon.com/en_us/forecast/latest/dg/API_CreateForecastExportJob.html">CreateForecastExportJob</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public Dictionary<string, string> Filters
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
        /// Gets and sets the property ForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the forecast to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ForecastArn
        {
            get { return this._forecastArn; }
            set { this._forecastArn = value; }
        }

        // Check to see if ForecastArn property is set
        internal bool IsSetForecastArn()
        {
            return this._forecastArn != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous request was truncated, the response includes a <code>NextToken</code>.
        /// To retrieve the next set of results, use the token in the next request. Tokens expire
        /// after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date for the forecast. Specify the date using this format: yyyy-MM-dd'T'HH:mm:ss
        /// (ISO 8601 format). For example, 2015-01-01T08:00:00.
        /// </para>
        /// </summary>
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate != null;
        }

    }
}