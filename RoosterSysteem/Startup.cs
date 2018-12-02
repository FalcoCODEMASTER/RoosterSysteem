using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoosterSysteem.Startup))]
namespace RoosterSysteem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
