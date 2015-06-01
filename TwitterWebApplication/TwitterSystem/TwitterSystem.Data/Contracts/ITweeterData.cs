namespace TwitterSystem.Data.Contracts
{
    using Microsoft.AspNet.Identity;
    using Models;

    public interface ITweeterData
    {
        IRepository<User> Users { get; }

        IRepository<Tweet> Tweets { get; }

        IRepository<Message> Messages { get; }

        IRepository<Notification> Notifications { get; }

        IRepository<Report> Reports { get; }

        IUserStore<User> UserStore { get; }

        int SaveChanges();
    }
}
