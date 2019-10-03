using System.Web;
using System.Web.Mvc;

namespace TechnicalInterview.Exercice3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
