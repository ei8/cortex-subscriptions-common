using ei8.Cortex.Subscriptions.Common.Attributes;
using ei8.Cortex.Subscriptions.Common.Receivers;
using System;
using System.Linq;

namespace ei8.Cortex.Subscriptions.Common.Extensions
{
    public static class IReceiverInfoExtensions
    {
        public static string GetSubscriptionPath(this IReceiverInfo receiverInfo)
        {
            var type = receiverInfo.GetType();
            var subscriptionPathAttribute = type.GetCustomAttributes(typeof(SubscriptionPathAttribute), false)
                                                .FirstOrDefault() as SubscriptionPathAttribute;

            if (subscriptionPathAttribute != null)
                return subscriptionPathAttribute.EndpointPath;

            else
                throw new ArgumentException($"Unsupported receiver info type: {type.FullName}");
        }
    }
}
