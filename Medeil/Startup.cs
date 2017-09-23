using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medeil.Startup))]
namespace Medeil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
