using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingSystem.WebUI.Models
{
    public class QuestionContent
    {
        public string ThemeName { get; set; }
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; } 
    }
}