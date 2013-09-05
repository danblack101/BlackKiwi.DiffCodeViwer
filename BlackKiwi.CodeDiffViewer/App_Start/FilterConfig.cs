using System.Web;
using System.Web.Mvc;

namespace BlackKiwi.CodeDiffViewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}