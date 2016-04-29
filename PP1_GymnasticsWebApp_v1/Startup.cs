using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PP1_GymnasticsWebApp_v1.Startup))]
namespace PP1_GymnasticsWebApp_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
