using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sinco.Startup))]
namespace Sinco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
