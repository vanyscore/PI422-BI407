using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspCitylink.Startup))]
namespace AspCitylink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
