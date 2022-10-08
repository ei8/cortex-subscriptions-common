using ei8.Cortex.Subscriptions.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Subscriptions.Common.Receivers
{
    [SubscriptionPath("smtp")]
    public class SmtpReceiverInfo : IReceiverInfo
    {
        /// <summary>
        /// Specifies the email address.
        /// </summary>
        public string EmailAddress { get; set; }
    }
}
