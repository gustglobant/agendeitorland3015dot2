using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agendeitorlands.Startup))]
namespace Agendeitorlands
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
