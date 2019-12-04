using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(interfazWeb.Startup))]
namespace interfazWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
