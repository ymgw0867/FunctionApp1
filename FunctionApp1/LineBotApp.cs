using System;
using System.Collections.Generic;
using System.Text;
using Line.Messaging;
using Line.Messaging.Webhooks;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1
{
    class LineBotApp : WebhookApplication
    {
        private LineMessagingClient MessagingClient { get; }
        //private TableStorage<BotStatus> SourceState { get; }
        private TraceWriter Log { get; }
    }
}
