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
    /// Provides the details of the <code>ExternalWorkflowExecutionCancelRequested</code>
    /// event.
    /// </summary>
    public partial class ExternalWorkflowExecutionCancelRequestedEventAttributes
    {
        private long? _initiatedEventId;
        private WorkflowExecution _workflowExecution;

        /// <summary>
        /// Gets and sets the property InitiatedEventId. 
        /// <para>
        /// The ID of the <code>RequestCancelExternalWorkflowExecutionInitiated</code> event corresponding
        /// to the <code>RequestCancelExternalWorkflowExecution</code> decision to cancel this
        /// external workflow execution. This information can be useful for diagnosing problems
        /// by tracing back the chain of events leading up to this event.
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
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The external workflow execution to which the cancellation request was delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecution WorkflowExecution
        {
            get { return this._workflowExecution; }
            set { this._workflowExecution = value; }
        }

        // Check to see if WorkflowExecution property is set
        internal bool IsSetWorkflowExecution()
        {
            return this._workflowExecution != null;
        }

    }
}