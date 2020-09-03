﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using networkApp.Models;
using networkApp.ViewModels;
using networkApp.ViewModels.Testing;

namespace networkApp.Controllers
{
    [Authorize]
    public class QuestionController : Controller
    {
        public int countAnswer;
        public string textAnswer;
        public bool firstTry = true;
        public static string _fileName;
        private int countQuestions;

        ApplicationContext _context;
        public QuestionController(ApplicationContext context)
        {
            _context = context;
        }

        public void fillQuestions(string fileName_)
        {
            List<QuestionViewModel> questions = new List<QuestionViewModel>();

            XDocument xdoc = XDocument.Load("Data/" + fileName_);
            var counterQuestions = 0;
            foreach (var _root in xdoc.Element("questions").Elements("question"))
            {
                counterQuestions++;
                var question = new QuestionViewModel();

                var questionNumber = _root.Attribute("num").Value;
                var questionText = _root.Element("textQuestion").Value;
                question.Num = int.Parse(questionNumber);
                question.Text = questionText;

                int countAnswer = 0;

                foreach (var _answer in _root.Element("answers").Elements("answer"))
                {
                    countAnswer++;
                    int num = int.Parse(_answer.Element("numAnswer").Value);
                    string text = _answer.Element("textAnswer").Value;
                    string type = _answer.Element("type").Value;
                    string valueAnswer = _answer.Element("true-answer").Value;

                    var answer = new AnswerViewModel(num, text, type, valueAnswer);
                    question.AnswerList.Add(answer);
                    question.CountAnswer.Add(countAnswer);
                }
                countQuestions = counterQuestions;
                questions.Add(question);
            }

            ViewBag.Questions = questions;
        }

        [HttpGet]
        public IActionResult Index(string fileName)
        {
            System.Console.WriteLine(User.Identity.Name);
            _fileName = fileName;
            fillQuestions(_fileName);

            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Result(Dictionary<string, List<string>> answers)
        {
            fillQuestions(_fileName);

            List<ReturnAnswerViewModel> listAnswers = new List<ReturnAnswerViewModel>();

            int result = 0;
            var isNull = answers.ContainsKey("__RequestVerificationToken");

            if (!isNull)
            {
                XDocument xdoc = XDocument.Load("Data/" + _fileName);

                foreach (var _root in xdoc.Element("questions").Elements("question"))
                {
                    var numQuestion = _root.Attribute("num").Value;

                    int countTrueAnswers = 0;
                    var XAnswer = new ReturnAnswerViewModel();
                    foreach (var _answer in _root.Element("answers").Elements("answer"))
                    {
                        string textAnswer = _answer.Element("textAnswer").Value;
                        string isTrueAnswer = _answer.Element("true-answer").Value;

                        if (isTrueAnswer == "true")
                        {
                            countTrueAnswers++;

                            XAnswer.NumQuestion = int.Parse(numQuestion);
                            XAnswer.TrueAnswers.Add(textAnswer);
                        }

                    }
                    XAnswer.CountTrueAnswers = countTrueAnswers;
                    listAnswers.Add(XAnswer);
                }

                foreach (var RAnswer in answers)
                {
                    foreach (var XAnswer in listAnswers)
                    {
                        bool isDouble = false;
                        if (int.Parse(RAnswer.Key) == XAnswer.NumQuestion && XAnswer.CountTrueAnswers == RAnswer.Value.Count)
                        {
                            bool WhileTrue = true;
                            for (int i = 0; i < XAnswer.CountTrueAnswers; i++)
                            {
                                if (WhileTrue)
                                {
                                    if (RAnswer.Value[i] == XAnswer.TrueAnswers[i])
                                    {
                                        if (!isDouble)
                                        {
                                            result++;
                                            isDouble = true;
                                        }
                                    }
                                    else if (isDouble)
                                    {
                                        result--;
                                    }
                                    else
                                    {
                                        WhileTrue = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }

            ViewBag.Ball = result;
            ViewBag.ResultAnswers = answers;
            
            var userMail = User.Identity.Name;
            var userId = _context.Users.Where(u => u.Email == userMail).Select(u => u.Id).FirstOrDefault();
            var test = new Tests
            {
               Name = _fileName.Replace("_", " ").Replace(".xml", ""),
               CountAllQuestions = countQuestions,
               TrueAnswersCount = result,
               Mark = (result / countQuestions * 100).ToString(),
               UserId = userId
            };
            _fileName = string.Empty;
            _context.Tests.Add(test);
            await _context.SaveChangesAsync();

            return View();
        }
    }
           
}