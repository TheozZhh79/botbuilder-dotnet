﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema.Teams
{
    using Newtonsoft.Json;

    /// <summary>
    /// Channel data specific to messages received in Microsoft Teams.
    /// </summary>
    public partial class TeamsChannelData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsChannelData"/> class.
        /// </summary>
        public TeamsChannelData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsChannelData"/> class.
        /// </summary>
        /// <param name="channel">Information about the channel in which the
        /// message was sent.</param>
        /// <param name="eventType">Type of event.</param>
        /// <param name="team">Information about the team in which the message
        /// was sent.</param>
        /// <param name="notification">Notification settings for the
        /// message.</param>
        /// <param name="tenant">Information about the tenant in which the
        /// message was sent.</param>
        public TeamsChannelData(ChannelInfo channel = default(ChannelInfo), string eventType = default(string), TeamInfo team = default(TeamInfo), NotificationInfo notification = default(NotificationInfo), TenantInfo tenant = default(TenantInfo))
        {
            Channel = channel;
            EventType = eventType;
            Team = team;
            Notification = notification;
            Tenant = tenant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about the channel in which the message was
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public ChannelInfo Channel { get; set; }

        /// <summary>
        /// Gets or sets type of event.
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets information about the team in which the message was
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "team")]
        public TeamInfo Team { get; set; }

        /// <summary>
        /// Gets or sets notification settings for the message.
        /// </summary>
        [JsonProperty(PropertyName = "notification")]
        public NotificationInfo Notification { get; set; }

        /// <summary>
        /// Gets or sets information about the tenant in which the message was
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "tenant")]
        public TenantInfo Tenant { get; set; }

        /// <summary>
        /// Gets or sets information about the meeting in which the message was
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "meeting")]
        public TeamsMeetingInfo Meeting { get; set; }
    }
}
