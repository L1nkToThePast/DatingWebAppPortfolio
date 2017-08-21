using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using DaSite.Models;

using Microsoft.AspNet.Identity.EntityFramework;

namespace DaSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            Session["UserID"] = userId;
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

        public ActionResult  ViewProfile(string profileID)
        {
            if (profileID != null)
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

                var displayModel = manager.FindById(profileID);

                Session["pId"] = profileID;

                IndexViewModel model = new IndexViewModel
                {
                    //UserData
                    UserName = displayModel.UserName,
                    Email = displayModel.Email,
                    BirthDate = displayModel.BirthDate,

                    Gender = displayModel.Gender,
                    Ethnicity = displayModel.Ethnicity,
                    //Hair = displayModel.Hair,
                    //Height = displayModel.Height,

                    //Toption = displayModel.Toption,
                    //Tseeking = displayModel.Tseeking,
                    Seeking = displayModel.Seeking,
                    Bio = displayModel.Bio,

                    Country = displayModel.Country,
                    Province = displayModel.Province,
                    City = displayModel.City,
                    //PostalCode
                    profPic = displayModel.ProfilePic,
                    
                    Age = 2017 - displayModel.BirthDate.Year
                };

                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}