﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// Supplementary parameter for media events.
    /// </summary>
    public partial class MediaEventValue
    {
        /// <summary>
        /// Initializes a new instance of the MediaEventValue class.
        /// </summary>
        public MediaEventValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaEventValue class.
        /// </summary>
        /// <param name="cardValue">Callback parameter specified in the Value
        /// field of the MediaCard that originated this event.</param>
        public MediaEventValue(object cardValue = default(object))
        {
            CardValue = cardValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets callback parameter specified in the Value field of the
        /// MediaCard that originated this event.
        /// </summary>
        [JsonProperty(PropertyName = "cardValue")]
        public object CardValue { get; set; }
    }
}
