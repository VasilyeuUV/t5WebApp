using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(t5WebApp.Startup))]
namespace t5WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
