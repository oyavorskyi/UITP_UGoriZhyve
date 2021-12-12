using System.Web;
using System.Web.Mvc;

namespace UITP_UGoriZhyve
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
