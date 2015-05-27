namespace TwitterSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Contracts;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TwitterDbContext : IdentityDbContext<User>, ITweeterDbContext
    {
        public TwitterDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //  remove all CASCADE DELETES
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
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
            return base.Set<T>();
        }
    }
}
