using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace TestsSeviceLib
{
    public class UITest
    {
        public int id { get; set; }
        public string name { get; set; }
        public int time { get; set; }

        public UITest()
        { }

        public UITest(string _n, int _t, int _i = -1)
        {
            name = _n;
            time = _t;
            id = _i;
        }

        public UITest(Test s)
        {
            name = s.Name;
            time = s.MinutesForTest;
            id = s.Id;
        }
    }

    public class UIQuestion
    {
        public UIQuestion(string questionText, int id = -1)
        {
            Id = id;
            QuestionText = questionText;
        }

        public int Id { get; set; }
        public string QuestionText { get; set; }
        public bool MultyChoice { get; set; }
    }

    public class UIAnswer
    {
        public UIAnswer(string answerText, bool isCorrect, int id = -1)
        {
            Id = id;
            AnswerText = answerText;
            IsCorrect = isCorrect;
        }

        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class UIStatistics
    {
        public string TestName { get; set; }
        public int TimeInMinutes { get; set; }
        public int NumberOfCorrect { get; set; }
        public decimal PercentOfCorrect { get; set; }
        public string TimeToShow { get; set; }

        public UIStatistics()
        {
        }
    }
}
