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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <code>SignalExternalWorkflowExecutionFailed</code> event.
    /// </summary>
    public partial class SignalExternalWorkflowExecutionFailedEventAttributes
    {
        private SignalExternalWorkflowExecutionFailedCause _cause;
        private string _control;
        private long? _decisionTaskCompletedEventId;
        private long? _initiatedEventId;
        private string _runId;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The cause of the failure. This information is generated by the system and can be useful
        /// for diagnostic purposes.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>cause</code> is set to <code>OPERATION_NOT_PERMITTED</code>, the decision
        /// failed because it lacked sufficient permissions. For details and example IAM policies,
        /// see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public SignalExternalWorkflowExecutionFailedCause Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// The data attached to the event that the decider can use in subsequent workflow tasks.
        /// This data isn't sent to the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <code>DecisionTaskCompleted</code> event corresponding to the decision
        /// task that resulted in the <code>SignalExternalWorkflowExecution</code> decision for
        /// this signal. This information can be useful for diagnosing problems by tracing back
        /// the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitiatedEventId. 
        /// <para>
        /// The ID of the <code>SignalExternalWorkflowExecutionInitiated</code> event corresponding
        /// to the <code>SignalExternalWorkflowExecution</code> decision to request this signal.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long InitiatedEventId
        {
            get { return this._initiatedEventId.GetValueOrDefault(); }
            set { this._initiatedEventId = value; }
        }

        // Check to see if InitiatedEventId property is set
        internal bool IsSetInitiatedEventId()
        {
            return this._initiatedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The <code>runId</code> of the external workflow execution that the signal was being
        /// delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The <code>workflowId</code> of the external workflow execution that the signal was
        /// being delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

    }
}