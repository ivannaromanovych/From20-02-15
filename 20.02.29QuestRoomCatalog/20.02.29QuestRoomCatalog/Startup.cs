using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20._02._29QuestRoomCatalog.Startup))]
namespace _20._02._29QuestRoomCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
