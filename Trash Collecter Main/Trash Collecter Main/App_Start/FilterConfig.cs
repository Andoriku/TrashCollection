﻿using System.Web;
using System.Web.Mvc;

namespace Trash_Collecter_Main
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}