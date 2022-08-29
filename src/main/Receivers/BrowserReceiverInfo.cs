using ei8.Cortex.Subscriptions.Common.Attributes;

namespace ei8.Cortex.Subscriptions.Common.Receivers
{
    [SubscriptionPath("web")]
    public class BrowserReceiverInfo : IReceiverInfo
    {
        /// <summary>
        /// The client device name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The unique push endpoint for this browser receiver
        /// </summary>
        public string PushEndpoint { get; set; }

        /// <summary>
        /// The receiver's secret key
        /// </summary>
        public string PushP256DH { get; set; }

        /// <summary>
        /// The receiver's public key
        /// </summary>
        public string PushAuth { get; set; }
    }
}
