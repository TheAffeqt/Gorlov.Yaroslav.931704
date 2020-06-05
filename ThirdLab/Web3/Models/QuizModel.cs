using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web3.Models
{
    public class QuizModel
    {
        [Required(ErrorMessage = "Ответ не введён")]
        public int answer { get; set; } = -1;
        
        public int rightAnswers { get; set; } = 0;
        public int count { get; set; } = 0;
        public List<string> Results { get; set; } = new List<string>();

        public QuizModel(string result, int rAnswer, int countAnswer)
        {

        }

        public QuizModel()
        {

        }
    }
}
