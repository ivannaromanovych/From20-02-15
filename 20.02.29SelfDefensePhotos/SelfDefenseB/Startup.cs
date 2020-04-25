using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelfDefenseB.Startup))]
namespace SelfDefenseB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
