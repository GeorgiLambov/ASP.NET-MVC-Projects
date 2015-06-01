namespace TwitterSystem.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface ITweeterDbContext
    {
        IDbSet<User> Users { get; }

        IDbSet<Tweet> Tweets { get; set; }

        IDbSet<Message> Messages { get; }

        IDbSet<Report> Reports { get; set; }

        IDbSet<Notification> Notifications { get; set; }

        int SaveChanges();

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
