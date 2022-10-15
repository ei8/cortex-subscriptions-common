using System.Collections.Generic;

namespace ei8.Cortex.Subscriptions.Common
{
    public class NotificationPayloadRequest
    {
        public NotificationTemplate TemplateType { get; set; }
        public Dictionary<string, object> TemplateValues { get; set; }
    }

    public static class NotificationTemplateParameters
    {
        public const string AvatarUrl = "avatarUrl";
        public const string ReceiverName = "receiverName";
    }
}
