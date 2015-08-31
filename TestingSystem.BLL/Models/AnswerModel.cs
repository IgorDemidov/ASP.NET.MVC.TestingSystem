using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.BLL.Models
{
    public class AnswerModel
    {
        public int Id { get; set; }
        public bool IsRight { get; set; }
        public string Text { get; set; }
    }
}
