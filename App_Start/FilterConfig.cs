using System.Web;
using System.Web.Mvc;

namespace u19074362_HomeworkAssignment_03
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
