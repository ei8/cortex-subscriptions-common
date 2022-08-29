using ei8.Cortex.Subscriptions.Common.Receivers;

namespace ei8.Cortex.Subscriptions.Common
{
    public interface IAddSubscriptionReceiverRequest
    { 
        SubscriptionInfo SubscriptionInfo { get; set; }
    }

    /// <summary>
    /// Contract for a generic request object for the subscription receiver endpoint
    /// </summary>
    public interface IAddSubscriptionReceiverRequest<T> : IAddSubscriptionReceiverRequest 
        where T : IReceiverInfo
    {
        T ReceiverInfo { get; set; }
    }
}
