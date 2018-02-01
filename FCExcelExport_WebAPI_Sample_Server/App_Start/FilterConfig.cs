using System.Web;
using System.Web.Mvc;

namespace FCExcelExport_WebAPI_Sample_Server
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
