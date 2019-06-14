﻿// Copyright(c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace Microsoft.BotKit.Adapters.Slack
{
    public class SlackEventMiddleware : IMiddleware
    {
        /// <summary>
        /// A middleware for Botkit developers using the BotBuilder SlackAdapter class.
        /// This middleware causes Botkit to emit message events by their `type` or `subtype` field rather than their default BotBuilder Activity type(limited to message or event).
        /// This keeps the new Botkit behavior consistent withprevious versions, and provides helpful filtering on the many event types that Slack sends.
        /// </summary>
        public async Task OnTurnAsync(ITurnContext context, NextDelegate next, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (context.Activity.Type == ActivityTypes.Event)
            {
                // Handle message sub-types
                if ((context.Activity.ChannelData as dynamic)?.subtype != null)
                {
                    (context.Activity.ChannelData as dynamic).botkitEventType = (context.Activity.ChannelData as dynamic).subtype;
                }
                else if ((context.Activity.ChannelData as dynamic)?.type != null)
                {
                    (context.Activity.ChannelData as dynamic).botkitEventType = (context.Activity.ChannelData as dynamic).type;
                }
            }

            await next(cancellationToken).ConfigureAwait(false);
        }
    }
}