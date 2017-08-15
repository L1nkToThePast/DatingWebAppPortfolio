using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaSite.Startup))]
namespace DaSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
