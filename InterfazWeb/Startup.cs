using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FENIC.Startup))]
namespace FENIC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
