using System.Web;
using System.Web.Mvc;

namespace WebAppProva2Lab2AnaMendes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
