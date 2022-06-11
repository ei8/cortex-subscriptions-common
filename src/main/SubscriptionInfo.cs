using System;

namespace ei8.Cortex.Subscriptions.Common
{
    public abstract class SubscriptionInfo
    {
        public Guid UserId { get; set; }
        public string AvatarUrl { get; set; }
    }
}