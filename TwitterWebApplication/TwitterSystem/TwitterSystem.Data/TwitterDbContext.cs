namespace TwitterSystem.Data
{
    using System;
    using System.Data.Entity;
    using Contracts;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TwitterDbContext : IdentityDbContext<User>, ITweeterDbContext
    {
        public TwitterDbContext()
            : base("DefaultConnection")
        {
        }

        public static TwitterDbContext Create()
        {
            return new TwitterDbContext();
        }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

        public IDbSet<Replay> Replays { get; set; }

        public IDbSet<Report> Reports { get; set; }

        public IDbSet<T> Set<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
