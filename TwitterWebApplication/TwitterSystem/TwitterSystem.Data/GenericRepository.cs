namespace TwitterSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Contracts;

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ITweeterDbContext dbContext;
        private IDbSet<T> dbSet;

        public GenericRepository(ITweeterDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
            }

            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public IDbSet<T> DbSet
        {
            get { return this.dbSet; }
        }

        public IQueryable<T> All()
        {
            return this.DbSet;
        }

        public T Find(object id)
        {
            return this.DbSet.Find(id);
        }

        public void Add(T entity)
        {
            this.ChangeState(entity, EntityState.Added);
        }

        public void Update(T entity)
        {
            this.ChangeState(entity, EntityState.Modified);
        }

        public void Remove(T entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public T Remove(object id)
        {
            var entity = this.Find(id);
            this.Remove(entity);
            return entity;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private void ChangeState(T entity, EntityState state)
        {
            var entry = this.dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = state;
        }
    }
}
