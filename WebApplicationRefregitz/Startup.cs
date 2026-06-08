using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplicationRefregitz.Startup))]
namespace WebApplicationRefregitz
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
           //(new installload()).InstallerLoad();
        }
    }
}
