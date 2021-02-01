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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// An object that contains the response from the <code>SendBulkTemplatedEmail</code>
    /// operation.
    /// </summary>
    public partial class BulkEmailDestinationStatus
    {
        private string _error;
        private string _messageId;
        private BulkEmailStatus _status;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// A description of an error that prevented a message being sent using the <code>SendBulkTemplatedEmail</code>
        /// operation.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique message identifier returned from the <code>SendBulkTemplatedEmail</code>
        /// operation.
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a message sent using the <code>SendBulkTemplatedEmail</code> operation.
        /// </para>
        ///  
        /// <para>
        /// Possible values for this parameter include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Success</code>: Amazon SES accepted the message, and will attempt to deliver
        /// it to the recipients.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRejected</code>: The message was rejected because it contained a virus.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MailFromDomainNotVerified</code>: The sender's email address or domain was
        /// not verified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConfigurationSetDoesNotExist</code>: The configuration set you specified does
        /// not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TemplateDoesNotExist</code>: The template you specified does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccountSuspended</code>: Your account has been shut down because of issues
        /// related to your email sending practices.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccountThrottled</code>: The number of emails you can send has been reduced
        /// because your account has exceeded its allocated sending limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccountDailyQuotaExceeded</code>: You have reached or exceeded the maximum
        /// number of emails you can send from your account in a 24-hour period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InvalidSendingPoolName</code>: The configuration set you specified refers to
        /// an IP pool that does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccountSendingPaused</code>: Email sending for the Amazon SES account was disabled
        /// using the <a>UpdateAccountSendingEnabled</a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConfigurationSetSendingPaused</code>: Email sending for this configuration
        /// set was disabled using the <a>UpdateConfigurationSetSendingEnabled</a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InvalidParameterValue</code>: One or more of the parameters you specified when
        /// calling this operation was invalid. See the error message for additional information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransientFailure</code>: Amazon SES was unable to process your request because
        /// of a temporary issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code>: Amazon SES was unable to process your request. See the error
        /// message for additional information.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BulkEmailStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}