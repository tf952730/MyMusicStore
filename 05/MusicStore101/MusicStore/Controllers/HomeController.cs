using MucicStoreEntity.UserAndRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
       //public string TestLogin(string username="messi",string pwd="123.abc")
       // {
       //     var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MucicStoreEntity.MusicContext()));
       // }
    }
}