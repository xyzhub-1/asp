﻿using System.Web;
using System.Web.Mvc;

namespace Razor_view_and_help
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
