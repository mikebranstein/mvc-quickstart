using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KRS.TimeTracking.Web.Context
{
    public static class UserContext
    {
        public static string UserName => HttpContext.Current.User.Identity.Name;
    }
}