using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEMO.Startup))]
namespace DEMO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
