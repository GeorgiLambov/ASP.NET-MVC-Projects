namespace TwitterSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public sealed class TweeterDbMigrationConfiguration : DbMigrationsConfiguration<TweetterDbContext>
    {
        public TweeterDbMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TweetterDbContext context)
        {
            if (!context.Users.Any())
            {
                this.CreateAdmin(context);
                //this.AddData();
            }
        }

        private void CreateAdmin(TweetterDbContext context)
        {
            var adminUserName = "admin";
            var adminEmail = "admin@admin.bg";
            var adminFullName = "System Administrator";
            var adminPass = "admin";
            var adminRole = "Administrator";

            var adminUser = new User()
            {
                UserName = adminUserName,
                FullName = adminFullName,
                Email = adminEmail,
            };

            var userStore = new UserStore<User>(context);
            var userManager = new UserManager<User>(userStore);
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false
            };

            var userCreateResult = userManager.Create(adminUser, adminPass);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }

            //Create the "Administrator" role
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(adminRole));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }

            // Add the "admin" user to "Administrator" role
            var addAdminRoleResult = userManager.AddToRole(adminUser.Id, adminRole);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void AddData()
        {
            // todo
        }
    }
}
