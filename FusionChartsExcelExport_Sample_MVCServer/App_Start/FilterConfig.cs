using System.Web;
using System.Web.Mvc;

namespace FusionChartsExcelExport_Sample_MVCServer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
