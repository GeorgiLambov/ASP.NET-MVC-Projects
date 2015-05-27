using Microsoft.Owin;

[assembly: OwinStartup(typeof(TwitterSystem.Web.Startup))]
namespace TwitterSystem.Web
{

    using Owin;
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterDbContext, TweeterDbMigrationConfiguration>());
           
            ConfigureAuth(app);
        }
    }
}
