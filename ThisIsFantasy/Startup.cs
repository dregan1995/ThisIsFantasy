using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThisIsFantasy.Startup))]
namespace ThisIsFantasy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
