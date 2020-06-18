using asp_net_identity_tutorial_basics_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace asp_net_identity_tutorial_basics_new.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public async Task<string> AddUser()
        {
            ApplicationUser user;
            ApplicationUserStore store = new ApplicationUserStore(new ApplicationDbContext());
            ApplicationUserManager userManager = new ApplicationUserManager(store);
            user = new ApplicationUser
            {
                UserName = "TestUser",
                Email = "muhammad.zubaid@hotmail.com",
                //DOB = DateTime.Now
            };
            var result = await userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                return result.Errors.First();
            }
            return "User Added";
        }
    }
}