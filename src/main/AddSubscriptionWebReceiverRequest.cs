using ei8.Cortex.Subscriptions.Common.Receivers;

namespace ei8.Cortex.Subscriptions.Common
{
    public class AddSubscriptionWebReceiverRequest : IAddSubscriptionReceiverRequest<BrowserReceiverInfo>
    {
        public SubscriptionInfo SubscriptionInfo { get; set; }
        public BrowserReceiverInfo ReceiverInfo { get; set; }
    }
}
