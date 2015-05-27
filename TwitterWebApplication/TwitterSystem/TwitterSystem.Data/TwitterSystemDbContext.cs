namespace TwitterSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TwitterSystemDbContext : IdentityDbContext<User>
    {
        public TwitterSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterSystemDbContext Create()
        {
            return new TwitterSystemDbContext();
        }
    }
}
