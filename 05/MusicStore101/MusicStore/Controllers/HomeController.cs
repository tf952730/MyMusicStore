using MucicStoreEntity.UserAndRole;
using MusicStoreEntity;
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
            var context = new EntityDbContext();
            var list= context.Albums.OrderByDescending(x => x.PublisherDate).Take(20).ToList();
            return View(list);
        }

        
       //public string TestLogin(string username="messi",string pwd="123.abc")
       // {
       //     var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MucicStoreEntity.MusicContext()));
       // }
    }
}