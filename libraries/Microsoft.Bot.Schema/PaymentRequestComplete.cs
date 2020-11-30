﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Payload delivered when completing a payment request.
    /// </summary>
    [Obsolete("Bot Framework no longer supports payments.")]
    public partial class PaymentRequestComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestComplete"/> class.
        /// </summary>
        public PaymentRequestComplete()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestComplete"/> class.
        /// </summary>
        /// <param name="id">Payment request ID.</param>
        /// <param name="paymentRequest">Initial payment request.</param>
        /// <param name="paymentResponse">Corresponding payment
        /// response.</param>
        public PaymentRequestComplete(string id = default(string), PaymentRequest paymentRequest = default(PaymentRequest), PaymentResponse paymentResponse = default(PaymentResponse))
        {
            Id = id;
            PaymentRequest = paymentRequest;
            PaymentResponse = paymentResponse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets payment request ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets initial payment request.
        /// </summary>
        [JsonProperty(PropertyName = "paymentRequest")]
        public PaymentRequest PaymentRequest { get; set; }

        /// <summary>
        /// Gets or sets corresponding payment response.
        /// </summary>
        [JsonProperty(PropertyName = "paymentResponse")]
        public PaymentResponse PaymentResponse { get; set; }
    }
}
