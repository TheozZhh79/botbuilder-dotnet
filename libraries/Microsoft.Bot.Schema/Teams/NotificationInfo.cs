﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema.Teams
{
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// Specifies if a notification is to be sent for the mentions.
    /// </summary>
    public partial class NotificationInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationInfo"/> class.
        /// </summary>
        public NotificationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationInfo"/> class.
        /// </summary>
        /// <param name="alert">true if notification is to be sent to the user,
        /// false otherwise.</param>
        public NotificationInfo(bool? alert = default(bool?))
        {
            Alert = alert;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets true if notification is to be sent to the user, false
        /// otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "alert")]
        public bool? Alert { get; set; }

        /// <summary>
        /// Gets or sets the value indicating if a notification is to be shown to the user while in a meeting,
        /// false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "alertInMeeting")]
        public bool? AlertInMeeting { get; set; }

        /// <summary>
        /// Gets or sets the value of the notification's external resource url.
        /// </summary>
        [JsonProperty(PropertyName = "externalResourceUrl")]
        public string ExternalResourceUrl { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
