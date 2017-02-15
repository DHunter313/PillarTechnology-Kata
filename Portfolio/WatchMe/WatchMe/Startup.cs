using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatchMe.Startup))]
namespace WatchMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
