﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Provides information about the requested transaction.
    /// </summary>
    [Obsolete("Bot Framework no longer supports payments.")]
    public partial class PaymentDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetails"/> class.
        /// </summary>
        public PaymentDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetails"/> class.
        /// </summary>
        /// <param name="total">Contains the total amount of the payment
        /// request.</param>
        /// <param name="displayItems">Contains line items for the payment
        /// request that the user agent may display.</param>
        /// <param name="shippingOptions">A sequence containing the different
        /// shipping options for the user to choose from.</param>
        /// <param name="modifiers">Contains modifiers for particular payment
        /// method identifiers.</param>
        /// <param name="error">Error description.</param>
        public PaymentDetails(PaymentItem total = default(PaymentItem), IList<PaymentItem> displayItems = default(IList<PaymentItem>), IList<PaymentShippingOption> shippingOptions = default(IList<PaymentShippingOption>), IList<PaymentDetailsModifier> modifiers = default(IList<PaymentDetailsModifier>), string error = default(string))
        {
            Total = total;
            DisplayItems = displayItems;
            ShippingOptions = shippingOptions;
            Modifiers = modifiers;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains the total amount of the payment request.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public PaymentItem Total { get; set; }

        /// <summary>
        /// Gets or sets contains line items for the payment request that the
        /// user agent may display.
        /// </summary>
        [JsonProperty(PropertyName = "displayItems")]
        public IList<PaymentItem> DisplayItems { get; set; }

        /// <summary>
        /// Gets or sets a sequence containing the different shipping options
        /// for the user to choose from.
        /// </summary>
        [JsonProperty(PropertyName = "shippingOptions")]
        public IList<PaymentShippingOption> ShippingOptions { get; set; }

        /// <summary>
        /// Gets or sets contains modifiers for particular payment method
        /// identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "modifiers")]
        public IList<PaymentDetailsModifier> Modifiers { get; set; }

        /// <summary>
        /// Gets or sets error description.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }
}
