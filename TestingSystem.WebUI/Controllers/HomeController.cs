using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingSystem.BLL;
using TestingSystem.BLL.Models;

namespace TestingSystem.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private Service service = new Service();

        public ActionResult Index()
        {
            List<ThemeModel> themeModels = service.GetThemeModelList();
            return View(themeModels);
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
