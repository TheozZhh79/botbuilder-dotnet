﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema.Teams
{
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a team or channel entity.
    /// </summary>
    public partial class MessageActionsPayloadConversation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageActionsPayloadConversation"/> class.
        /// </summary>
        public MessageActionsPayloadConversation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageActionsPayloadConversation"/> class.
        /// </summary>
        /// <param name="conversationIdentityType">The type of conversation,
        /// whether a team or channel. Possible values include: 'team',
        /// 'channel'.</param>
        /// <param name="id">The id of the team or channel.</param>
        /// <param name="displayName">The plaintext display name of the team or
        /// channel entity.</param>
        public MessageActionsPayloadConversation(string conversationIdentityType = default(string), string id = default(string), string displayName = default(string))
        {
            ConversationIdentityType = conversationIdentityType;
            Id = id;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets the type of conversation, whether a team or channel.
        /// Possible values include: 'team', 'channel'.
        /// </summary>
        [JsonProperty(PropertyName = "conversationIdentityType")]
        public string ConversationIdentityType { get; set; }

        /// <summary>
        /// Gets or sets the id of the team or channel.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the plaintext display name of the team or channel
        /// entity.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
