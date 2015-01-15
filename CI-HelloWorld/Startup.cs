using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CI_HelloWorld.Startup))]
namespace CI_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
