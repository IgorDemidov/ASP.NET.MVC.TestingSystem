using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingSystem.BLL;
using TestingSystem.BLL.Models;
using WebGrease.Css.Extensions;

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
            QuestionModel questionModel = service.GetFirstQuestionModel(themeModel);
            return View(questionModel);
        }

        [HttpPost]
        public ActionResult Test(int questionId)
        {
            int[] checkedAnswerId = Request.Form["userTrueAnswers"].Split(',').Select(int.Parse).ToArray();
            
            QuestionModel questionModel = service.GetNextQuestionModel(questionId);
            if (questionModel==null)
            {
                return View("TestResult");
            }
            return View(questionModel);
        }

        private bool IsAnswersRight(int questionId, int[] checkedAnswerId)
        {
            QuestionModel currQuestionModel = service.GetQuestionModelById(questionId);
            int[] rightAnswerId = currQuestionModel.AnswerModels.Where(a => a.IsRight).Select(a => a.Id).ToArray();

            if (checkedAnswerId.Length != rightAnswerId.Length)
                return false;

            for (int i = 0; i < rightAnswerId.Length; i++)
            {
                if (rightAnswerId[i].Equals(checkedAnswerId[i]))
                    return false;
            }
            return true;
        }
    }      
}
