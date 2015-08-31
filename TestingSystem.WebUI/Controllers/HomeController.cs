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
        private TestingService service = new TestingService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Themes()
        {
            List<ThemeModel> themeModels = service.GetThemeModelList();
            return View(themeModels);
        }

        public ActionResult TestInfo(ThemeModel themeModel)
        {
            ViewBag.QuestionCount = service.GetQuestionCount(themeModel);
            return View(themeModel);
        }

        [HttpGet]
        public ActionResult Test(ThemeModel themeModel)
        {
            QuestionModel questionModelModel = service.GetFirstQuestionModel(themeModel);
            return View(questionModelModel);
        }

        [HttpPost]
        public ActionResult Test(QuestionModel questionModel)
        {
            QuestionModel questionModelModel = service.GetNextQuestionModel(questionModel);
            return View(questionModelModel);
        }
    }      
}
