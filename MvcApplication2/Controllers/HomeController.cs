using System.Linq;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        private const string DB_DIR = @"C:\Users\AldenQuimby\Desktop\Tables";
        private const string TABLE = @"HomeIndexViewModel";

        public ActionResult Index()
        {
            using (var db = new FileDb(DB_DIR))
            {
                var vm = db.GetTable<ViewModel>(TABLE);

                if (vm == null)
                {
                    var user = new User
                    {
                        Email = "aldenquimby@gmail.com",
                        FirstName = "Alden",
                        LastName = "Quimby",
                        Username = "aldenquimby",
                    };

                    var userSites = Site.KnownSites().Select(x => new UserSite
                    {
                        Site = x,
                        User = user,
                    }).ToList();

                    vm = new ViewModel
                    {
                        User = user,
                        UserSites = userSites,
                    };

                    db.SaveTable(TABLE, vm);
                }

                return View(vm);
            }
        }

        public ActionResult Update(string name, int pk, string value)
        {
            using (var db = new FileDb(DB_DIR))
            {
                var vm = db.GetTable<ViewModel>(TABLE);

                var userSiteToUpdate = vm.UserSites.Single(x => x.Site.Id == pk);

                if (name == "username")
                {
                    userSiteToUpdate.Username = value;
                }
                else if (name == "userid")
                {
                    userSiteToUpdate.UserId = value;
                }

                db.SaveTable(TABLE, vm);
            }

            return Json(new {Success = true});
        }

        public ActionResult Create(string site, string username, string userid, string profileurl)
        {
            var siteToUse = Site.KnownSites().Single(x => x.Type.ToString() == site);

            using (var db = new FileDb(DB_DIR))
            {
                var vm = db.GetTable<ViewModel>(TABLE);

                var existingUserSite = vm.UserSites.SingleOrDefault(x => x.Site.Id == siteToUse.Id);

                if (existingUserSite != null)
                {
                    return Json(new {Success = false});
                }

                vm.UserSites.Add(new UserSite
                {
                    Site = siteToUse,
                    User = vm.User,
                    ProfileUrl = profileurl,
                    UserId = userid,
                    Username = username,
                });

                db.SaveTable(TABLE, vm);
            }

            return Json(new {Success = true});
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
