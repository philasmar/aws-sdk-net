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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetLoadBalancerMetricData operation.
    /// Returns information about health metrics for your Lightsail load balancer.
    /// 
    ///  
    /// <para>
    /// Metrics report the utilization of your resources, and the error counts generated by
    /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
    /// and performance of your resources.
    /// </para>
    /// </summary>
    public partial class GetLoadBalancerMetricDataRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private string _loadBalancerName;
        private LoadBalancerMetricName _metricName;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = new List<string>();
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric for which you want to return information.
        /// </para>
        ///  
        /// <para>
        /// Valid load balancer metric names are listed below, along with the most useful <code>statistics</code>
        /// to include in your request, and the published <code>unit</code> value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>ClientTLSNegotiationErrorCount</code> </b> - The number of TLS connections
        /// initiated by the client that did not establish a session with the load balancer due
        /// to a TLS error generated by the load balancer. Possible causes include a mismatch
        /// of ciphers or protocols.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HealthyHostCount</code> </b> - The number of target instances that are
        /// considered healthy.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic are <code>Average</code>, <code>Minimum</code>,
        /// and <code>Maximum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_2XX_Count</code> </b> - The number of HTTP 2XX response
        /// codes generated by the target instances. This does not include any response codes
        /// generated by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_3XX_Count</code> </b> - The number of HTTP 3XX response
        /// codes generated by the target instances. This does not include any response codes
        /// generated by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_4XX_Count</code> </b> - The number of HTTP 4XX response
        /// codes generated by the target instances. This does not include any response codes
        /// generated by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_5XX_Count</code> </b> - The number of HTTP 5XX response
        /// codes generated by the target instances. This does not include any response codes
        /// generated by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_LB_4XX_Count</code> </b> - The number of HTTP 4XX client error
        /// codes that originated from the load balancer. Client errors are generated when requests
        /// are malformed or incomplete. These requests were not received by the target instance.
        /// This count does not include response codes generated by the target instances.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_LB_5XX_Count</code> </b> - The number of HTTP 5XX server error
        /// codes that originated from the load balancer. This does not include any response codes
        /// generated by the target instance. This metric is reported if there are no healthy
        /// instances attached to the load balancer, or if the request rate exceeds the capacity
        /// of the instances (spillover) or the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>InstanceResponseTime</code> </b> - The time elapsed, in seconds, after
        /// the request leaves the load balancer until a response from the target instance is
        /// received.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Seconds</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>RejectedConnectionCount</code> </b> - The number of connections that were
        /// rejected because the load balancer had reached its maximum number of connections.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>RequestCount</code> </b> - The number of requests processed over IPv4.
        /// This count includes only the requests with a response generated by a target instance
        /// of the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>UnhealthyHostCount</code> </b> - The number of target instances that are
        /// considered unhealthy.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic are <code>Average</code>, <code>Minimum</code>,
        /// and <code>Maximum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoadBalancerMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistic for the metric.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Minimum</code> - The lowest value observed during the specified period. Use
        /// this value to determine low volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maximum</code> - The highest value observed during the specified period. Use
        /// this value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Sum</code> - All values submitted for the matching metric added together. You
        /// can use this statistic to determine the total volume of a metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Average</code> - The value of Sum / SampleCount during the specified period.
        /// By comparing this statistic with the Minimum and Maximum values, you can determine
        /// the full scope of a metric and how close the average use is to the Minimum and Maximum
        /// values. This comparison helps you to know when to increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SampleCount</code> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric data request. Valid units depend on the metric data being
        /// requested. For the valid units with each available metric, see the <code>metricName</code>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}