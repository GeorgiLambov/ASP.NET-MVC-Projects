using Microsoft.Owin;
using TwitterSystem.Web;

[assembly: OwinStartup(typeof(Startup))]
namespace TwitterSystem.Web
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           ConfigureAuth(app);
        }
    }
}
