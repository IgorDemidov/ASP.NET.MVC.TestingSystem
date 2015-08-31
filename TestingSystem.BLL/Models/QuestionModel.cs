using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.BLL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ThemeName { get; set; }
        public List<AnswerModel> AnswerModels { get; set; }
    }
}
