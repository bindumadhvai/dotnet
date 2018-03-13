using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(app2.Startup))]
namespace app2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
