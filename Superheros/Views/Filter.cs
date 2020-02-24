
using System.Web;
using System.Web.Mvc;


namespace Superheros.Views
{
    public class Filter
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
