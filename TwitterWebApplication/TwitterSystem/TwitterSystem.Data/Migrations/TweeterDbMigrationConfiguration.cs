namespace TwitterSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class TweeterDbMigrationConfiguration : DbMigrationsConfiguration<TwitterDbContext>
    {
        public TweeterDbMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterDbContext context)
        {
            if (!context.Users.Any())
            {
                //this.AddData();
            }
        }

        private void AddData()
        {
            var person = new User
            {
                Email = "test@test123.com",
                FullName = "Gogo Gogov",
                UserName = "gogo"
            };

            var person2 = new User
            {
                Email = "test12@test12.com",
                FullName = "Pesho Gogov",
                UserName = "pesho"
            };

            var person3 = new User
            {
                Email = "test123@test123.com",
                FullName = "Mimi Mimi",
                UserName = "mimi"
            };
        }
    }
}
