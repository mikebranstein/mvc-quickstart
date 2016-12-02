using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KRS.TimeTracking.Web.Models
{
    public class HelloViewModel
    {
        public string Message { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public string CurrentUser { get; set; }
    }
}