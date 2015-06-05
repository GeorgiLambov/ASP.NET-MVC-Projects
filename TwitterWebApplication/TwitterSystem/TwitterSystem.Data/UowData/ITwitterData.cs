namespace TwitterSystem.Data.UowData
{
    using Microsoft.AspNet.Identity;
    
    using Models;
    using Repository;

    public interface ITwitterData
    {
        IRepository<User> Users { get; }

        IRepository<Tweet> Tweets { get; }

        IRepository<Message> Messages { get; }

        IRepository<Notification> Notifications { get; }

        IRepository<Report> Reports { get; }

        IUserStore<User> UserStore { get; }

        void SaveChanges();
    }
}
