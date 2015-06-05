namespace TwitterSystem.Web.ViewModels.Notifications
{
    using System;
    using Twitter.Web.Infrastructure.Mapping;
    using TwitterSystem.Models;

    public class NotificationViewModel : IMapFrom<Notification>
    {
        public NotificationType Type { get; set; }

        public string Text { get; set; }

        public bool IsRead { get; set; }

        public DateTime NotificationTime { get; set; }
    }
}
