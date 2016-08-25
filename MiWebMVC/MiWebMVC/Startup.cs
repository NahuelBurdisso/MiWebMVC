using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiWebMVC.Startup))]
namespace MiWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
