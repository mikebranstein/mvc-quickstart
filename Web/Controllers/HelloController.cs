using KRS.TimeTracking.Data;
using KRS.TimeTracking.Web.Context;
using KRS.TimeTracking.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KRS.TimeTracking.Web.Controllers
{
    public class HelloController : Controller
    {
        private IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        // GET: Hello
        public ActionResult Index()
        {
            var helloViewModel = new HelloViewModel();
            helloViewModel.Message = _helloService.GetHelloMessage();
            helloViewModel.CurrentDateTime = DateTime.Now;
            helloViewModel.CurrentUser = UserContext.UserName;

            return View(helloViewModel);
        }

        // POST: Hello
        [HttpPost]
        public ActionResult Index(HelloViewModel helloViewModel)
        {
            // do something with the view model
            return View(helloViewModel);
        }
    }
}