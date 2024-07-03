using System.Web;
using System.Web.Mvc;

namespace Pvvk22cntt3lesson10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
