using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conselho.Startup))]
namespace Conselho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
