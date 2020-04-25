using System.Web;
using System.Web.Mvc;

namespace _20._02._29QuestRoomCatalog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
