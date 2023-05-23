using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THLTWT3.Startup))]
namespace THLTWT3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
