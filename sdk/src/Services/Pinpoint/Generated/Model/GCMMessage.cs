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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a one-time message that's sent directly to an endpoint
    /// through the GCM channel. The GCM channel enables Amazon Pinpoint to send messages
    /// to the Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging (GCM), service.
    /// </summary>
    public partial class GCMMessage
    {
        private Action _action;
        private string _body;
        private string _collapseKey;
        private Dictionary<string, string> _data = new Dictionary<string, string>();
        private string _iconReference;
        private string _imageIconUrl;
        private string _imageUrl;
        private string _priority;
        private string _rawContent;
        private string _restrictedPackageName;
        private bool? _silentPush;
        private string _smallImageIconUrl;
        private string _sound;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
        private int? _timeToLive;
        private string _title;
        private string _url;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if the recipient taps the push notification. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background.
        /// This is the default action.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DEEP_LINK - Your app opens and displays a designated user interface in the app. This
        /// action uses the deep-linking features of the Android platform.
        /// </para>
        /// </li> <li>
        /// <para>
        /// URL - The default mobile browser on the recipient's device opens and loads the web
        /// page at a URL that you specify.
        /// </para>
        /// </li></ul>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the notification message.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property CollapseKey. 
        /// <para>
        /// An arbitrary string that identifies a group of messages that can be collapsed to ensure
        /// that only the last message is sent when delivery can resume. This helps avoid sending
        /// too many instances of the same messages when the recipient's device comes online again
        /// or becomes active.
        /// </para>
        ///  
        /// <para>
        /// Amazon Pinpoint specifies this value in the Firebase Cloud Messaging (FCM) collapse_key
        /// parameter when it sends the notification message to FCM.
        /// </para>
        /// </summary>
        public string CollapseKey
        {
            get { return this._collapseKey; }
            set { this._collapseKey = value; }
        }

        // Check to see if CollapseKey property is set
        internal bool IsSetCollapseKey()
        {
            return this._collapseKey != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The JSON data payload to use for the push notification, if the notification is a silent
        /// push notification. This payload is added to the data.pinpoint.jsonBody object of the
        /// notification.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null && this._data.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IconReference. 
        /// <para>
        /// The icon image name of the asset saved in your app.
        /// </para>
        /// </summary>
        public string IconReference
        {
            get { return this._iconReference; }
            set { this._iconReference = value; }
        }

        // Check to see if IconReference property is set
        internal bool IsSetIconReference()
        {
            return this._iconReference != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIconUrl. 
        /// <para>
        /// The URL of the large icon image to display in the content view of the push notification.
        /// </para>
        /// </summary>
        public string ImageIconUrl
        {
            get { return this._imageIconUrl; }
            set { this._imageIconUrl = value; }
        }

        // Check to see if ImageIconUrl property is set
        internal bool IsSetImageIconUrl()
        {
            return this._imageIconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image to display in the push notification.
        /// </para>
        /// </summary>
        public string ImageUrl
        {
            get { return this._imageUrl; }
            set { this._imageUrl = value; }
        }

        // Check to see if ImageUrl property is set
        internal bool IsSetImageUrl()
        {
            return this._imageUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// para>normal - The notification might be delayed. Delivery is optimized for battery
        /// usage on the recipient's device. Use this value unless immediate delivery is required.
        /// </para>
        /// /listitem> <li>
        /// <para>
        /// high - The notification is sent immediately and might wake a sleeping device.
        /// </para>
        /// </li>/para> 
        /// <para>
        /// Amazon Pinpoint specifies this value in the FCM priority parameter when it sends the
        /// notification message to FCM.
        /// </para>
        ///  
        /// <para>
        /// The equivalent values for Apple Push Notification service (APNs) are 5, for normal,
        /// and 10, for high. If you specify an APNs value for this property, Amazon Pinpoint
        /// accepts and converts the value to the corresponding FCM value.
        /// </para>
        /// </summary>
        public string Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for the notification message.
        /// If specified, this value overrides all other content for the message.
        /// </para>
        /// </summary>
        public string RawContent
        {
            get { return this._rawContent; }
            set { this._rawContent = value; }
        }

        // Check to see if RawContent property is set
        internal bool IsSetRawContent()
        {
            return this._rawContent != null;
        }

        /// <summary>
        /// Gets and sets the property RestrictedPackageName. 
        /// <para>
        /// The package name of the application where registration tokens must match in order
        /// for the recipient to receive the message.
        /// </para>
        /// </summary>
        public string RestrictedPackageName
        {
            get { return this._restrictedPackageName; }
            set { this._restrictedPackageName = value; }
        }

        // Check to see if RestrictedPackageName property is set
        internal bool IsSetRestrictedPackageName()
        {
            return this._restrictedPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property SilentPush. 
        /// <para>
        /// Specifies whether the notification is a silent push notification, which is a push
        /// notification that doesn't display on a recipient's device. Silent push notifications
        /// can be used for cases such as updating an app's configuration or supporting phone
        /// home functionality.
        /// </para>
        /// </summary>
        public bool SilentPush
        {
            get { return this._silentPush.GetValueOrDefault(); }
            set { this._silentPush = value; }
        }

        // Check to see if SilentPush property is set
        internal bool IsSetSilentPush()
        {
            return this._silentPush.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SmallImageIconUrl. 
        /// <para>
        /// The URL of the small icon image to display in the status bar and the content view
        /// of the push notification.
        /// </para>
        /// </summary>
        public string SmallImageIconUrl
        {
            get { return this._smallImageIconUrl; }
            set { this._smallImageIconUrl = value; }
        }

        // Check to see if SmallImageIconUrl property is set
        internal bool IsSetSmallImageIconUrl()
        {
            return this._smallImageIconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Sound. 
        /// <para>
        /// The sound to play when the recipient receives the push notification. You can use the
        /// default stream or specify the file name of a sound resource that's bundled in your
        /// app. On an Android platform, the sound file must reside in /res/raw/.
        /// </para>
        /// </summary>
        public string Sound
        {
            get { return this._sound; }
            set { this._sound = value; }
        }

        // Check to see if Sound property is set
        internal bool IsSetSound()
        {
            return this._sound != null;
        }

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The default message variables to use in the notification message. You can override
        /// the default variables with individual address variables.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && this._substitutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The amount of time, in seconds, that FCM should store and attempt to deliver the push
        /// notification, if the service is unable to deliver the notification the first time.
        /// If you don't specify this value, FCM defaults to the maximum value, which is 2,419,200
        /// seconds (28 days).
        /// </para>
        ///  
        /// <para>
        /// Amazon Pinpoint specifies this value in the FCM time_to_live parameter when it sends
        /// the notification message to FCM.
        /// </para>
        /// </summary>
        public int TimeToLive
        {
            get { return this._timeToLive.GetValueOrDefault(); }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to display above the notification message on the recipient's device.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to open in the recipient's default mobile browser, if a recipient taps the
        /// push notification and the value of the Action property is URL.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}