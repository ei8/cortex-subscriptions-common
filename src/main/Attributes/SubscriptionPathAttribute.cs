using System;

namespace ei8.Cortex.Subscriptions.Common.Attributes
{
    /// <summary>
    /// Specifies the relative endpoint path this class can be used with
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class SubscriptionPathAttribute : Attribute
    {
        /// <summary>
        /// Initialize this SubscriptionPathAttribute with the specified relative endpoint path
        /// </summary>
        /// <param name="endpointPath">The path relative to the subscription endpoint, e.g. "subscriptions/receivers/{endpointPath}"</param>
        public SubscriptionPathAttribute(string endpointPath)
        {
            EndpointPath = endpointPath;
        }

        /// <summary>
        /// The path relative to the subscription endpoint, e.g. "subscriptions/receivers/{EndpointPath}"
        /// </summary>
        public string EndpointPath { get; }
    }
}
