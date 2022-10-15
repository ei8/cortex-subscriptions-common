using ei8.Cortex.Subscriptions.Common.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Subscriptions.Common
{
    public class AddSubscriptionSmtpReceiverRequest : IAddSubscriptionReceiverRequest<SmtpReceiverInfo>
    {
        public SmtpReceiverInfo ReceiverInfo { get; set; }
        public SubscriptionInfo SubscriptionInfo { get; set; }
    }
}
