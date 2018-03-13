﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder.Core.Extensions
{
    public class ShowTypingMiddleware : IMiddleware
    {
        /// <summary>
        /// (Optional) initial delay before sending first typing indicator. Defaults to 500ms.
        /// </summary>
        private readonly int _delay;

        /// <summary>
        /// (Optional) rate at which additional typing indicators will be sent. Defaults to every 2000ms.
        /// </summary>
        private readonly int _freqency;

        public ShowTypingMiddleware(int delay = 500, int frequency = 2000)
        {
            _delay = delay;
            _freqency = frequency;
        }

        public async Task OnProcessRequest(IBotContext context, MiddlewareSet.NextDelegate next)
        {
            Timer typingActivityTimer = null;

            // If the incoming activity is a MessageActivity, start a timer to periodically send the typing activity
            if (context.Request.Type == ActivityTypes.Message)
            {
                typingActivityTimer = new Timer(SendTypingTimerCallback, context, _delay, _freqency);
            }

            await next().ConfigureAwait(false);

            // Once the bot has processed the request, the middleware should dispose of the timer
            // on the trailing edge of the request
            typingActivityTimer?.Dispose();
        }

        private void SendTypingTimerCallback(object state)
        {
            var context = (IBotContext) state;
            SendTypingActivity(context);
        }

        private void SendTypingActivity(IBotContext context)
        {
            // create a TypingActivity, associate it with the conversation 
            // and send immediately
            var typingActivity = new Activity
            {
                Type = ActivityTypes.Typing,
                RelatesTo = context.Request.RelatesTo
            };
            context.SendActivity(typingActivity);
        }
    }
}
