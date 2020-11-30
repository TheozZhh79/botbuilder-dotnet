﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Replies in response to <see cref="DeliveryModes.ExpectReplies"/>.
    /// </summary>
    public partial class ExpectedReplies
    {
        /// <summary>
        /// Initializes a new instance of the ExpectedReplies class.
        /// </summary>
        public ExpectedReplies()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpectedReplies class.
        /// </summary>
        /// <param name="activities">A collection of Activities that conforms
        /// to the ExpectedReplies schema.</param>
        public ExpectedReplies(IList<Activity> activities = default(IList<Activity>))
        {
            Activities = activities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of Activities that conforms to the
        /// ExpectedReplies schema.
        /// </summary>
        [JsonProperty(PropertyName = "activities")]
        public IList<Activity> Activities { get; set; }

    }
}
