using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThySok.Startup))]
namespace ThySok
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
