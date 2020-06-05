using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web3.Models;

namespace Web3.Controllers
{
    public class QuizController : Controller
    {
        static QuizModel quiz = new QuizModel();
        static Random rand = new Random();
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            if (ModelState.IsValid)
            {
                ViewBag.numb1 = rand.Next(10);
                ViewBag.numb2 = rand.Next(10);
                return View();
            }

            return View();
        }

        public IActionResult QuizResult()
        {
            if (ModelState.IsValid)
            {
                ViewBag.ListResult = quiz.Results;
                ViewBag.RightAnswersCount = quiz.rightAnswers;
                ViewBag.AnswersCount = quiz.count;
                return View();
            }

            return View();
        }
         
       public void QuizLogic (string value1, string value2, string answer)
       {
            int _value1 = Convert.ToInt32(value1);
            int _value2 = Convert.ToInt32(value2);
            int _answer = Convert.ToInt32(answer);

            quiz.Results.Add(_value1 + " + " + _value2 + " = " + _answer);
            quiz.count++;

            if (_value1 + _value2 == _answer)
            {
                quiz.rightAnswers++;
            }

            ViewBag.numb1 = rand.Next(10);
            ViewBag.numb2 = rand.Next(10);
       }
        
        
        [HttpPost]
        public IActionResult Next(string value1, string value2, string answer)
        {
            QuizLogic(value1, value2, answer);
            return View("quiz");
        }

        [HttpPost]
        public IActionResult Finish(string value1, string value2, string answer)
        {
            QuizLogic(value1, value2, answer);
            ViewBag.ListResult = quiz.Results;
            ViewBag.RightAnswersCount = quiz.rightAnswers;
            ViewBag.AnswersCount = quiz.count;
            return View("quizResult");
        }

    }
}