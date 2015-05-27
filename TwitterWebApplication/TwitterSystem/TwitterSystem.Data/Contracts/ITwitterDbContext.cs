namespace TwitterSystem.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface ITweeterDbContext
    {
        IDbSet<Tweet> Tweets { get; set; }

        IDbSet<Notification> Notifications { get; set; }

        IDbSet<Replay> Replays { get; set; }

        IDbSet<Report> Reports { get; set; }

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
