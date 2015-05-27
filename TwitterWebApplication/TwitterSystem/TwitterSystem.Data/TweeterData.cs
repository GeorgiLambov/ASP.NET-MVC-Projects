namespace TwitterSystem.Data
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Models;

    public class TweeterData : ITweeterData
    {
        private ITweeterDbContext context;
        private IDictionary<Type, object> repositories;

        public TweeterData(ITweeterDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context", "An instance of ITweeterDbContext is required.");
            }
            
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Notification> Notifications
        {
            get { return this.GetRepository<Notification>(); }
        }

        public IRepository<Replay> Replays
        {
            get { return this.GetRepository<Replay>(); }
        }

        public IRepository<Report> Reports
        {
            get { return this.GetRepository<Report>(); }
        }

        public IRepository<Tweet> Tweets
        {
            get { return this.GetRepository<Tweet>(); }
        }

        public ITweeterDbContext Context
        {
            get { return this.context; }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T),
                    Activator.CreateInstance(type, this.Context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
