using System.Web;
using System.Web.Mvc;

namespace Basic_Dynamic_profile
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
