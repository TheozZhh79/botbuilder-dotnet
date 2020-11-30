﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// Response schema sent back from Bot Framework Token Service required to initiate a user single sign on.
    /// </summary>
    public partial class TokenExchangeResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeResource"/> class.
        /// </summary>
        public TokenExchangeResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeResource"/> class.
        /// </summary>
        public TokenExchangeResource(string id = default(string), string uri = default(string), string providerId = default(string))
        {
            Id = id;
            Uri = uri;
            ProviderId = providerId;
            CustomInit();
        }

        /// <summary>
        /// A unique identifier for this token exchange instance.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The application ID / resource identifier with which to exchange a token on behalf of.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The identifier of the provider with which to attempt a token exchange
        /// A value of null or empty will default to Azure Active Directory.
        /// </summary>
        [JsonProperty(PropertyName = "providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
