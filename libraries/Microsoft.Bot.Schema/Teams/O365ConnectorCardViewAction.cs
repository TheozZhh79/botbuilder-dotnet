﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema.Teams
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// O365 connector card ViewAction action.
    /// </summary>
    public partial class O365ConnectorCardViewAction : O365ConnectorCardActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365ConnectorCardViewAction"/> class.
        /// </summary>
        public O365ConnectorCardViewAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="O365ConnectorCardViewAction"/> class.
        /// </summary>
        /// <param name="type">Type of the action. Possible values include:
        /// 'ViewAction', 'OpenUri', 'HttpPOST', 'ActionCard'.</param>
        /// <param name="name">Name of the action that will be used as button
        /// title.</param>
        /// <param name="id">Action Id.</param>
        /// <param name="target">Target urls, only the first url effective for
        /// card button.</param>
        public O365ConnectorCardViewAction(string type = default(string), string name = default(string), string id = default(string), IList<string> target = default(IList<string>))
            : base(type, name, id)
        {
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets target urls, only the first url effective for card button.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public IList<string> Target { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
