﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A request to make a payment.
    /// </summary>
    [Obsolete("Bot Framework no longer supports payments.")]
    public partial class PaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest"/> class.
        /// </summary>
        public PaymentRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest"/> class.
        /// </summary>
        /// <param name="id">ID of this payment request.</param>
        /// <param name="methodData">Allowed payment methods for this
        /// request.</param>
        /// <param name="details">Details for this request.</param>
        /// <param name="options">Provides information about the options
        /// desired for the payment request.</param>
        /// <param name="expires">Expiration for this request, in ISO 8601
        /// duration format (e.g., 'P1D').</param>
        public PaymentRequest(string id = default(string), IList<PaymentMethodData> methodData = default(IList<PaymentMethodData>), PaymentDetails details = default(PaymentDetails), PaymentOptions options = default(PaymentOptions), string expires = default(string))
        {
            Id = id;
            MethodData = methodData;
            Details = details;
            Options = options;
            Expires = expires;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of this payment request.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets allowed payment methods for this request.
        /// </summary>
        [JsonProperty(PropertyName = "methodData")]
        public IList<PaymentMethodData> MethodData { get; set; }

        /// <summary>
        /// Gets or sets details for this request.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public PaymentDetails Details { get; set; }

        /// <summary>
        /// Gets or sets provides information about the options desired for the
        /// payment request.
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public PaymentOptions Options { get; set; }

        /// <summary>
        /// Gets or sets expiration for this request, in ISO 8601 duration
        /// format (e.g., 'P1D').
        /// </summary>
        [JsonProperty(PropertyName = "expires")]
        public string Expires { get; set; }
    }
}
