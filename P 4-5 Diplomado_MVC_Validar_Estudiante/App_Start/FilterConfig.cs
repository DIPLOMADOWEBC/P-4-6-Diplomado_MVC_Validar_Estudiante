using System.Web;
using System.Web.Mvc;

namespace P_4_5_Diplomado_MVC_Validar_Estudiante
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
