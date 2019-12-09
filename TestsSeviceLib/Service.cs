using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace TestsSeviceLib
{
    public class Service
    {
        Test2DBContainer DbContext;

        public Service()
        {
            DbContext = new Test2DBContainer();
        }

        public Service(Test2DBContainer _context)
        {
            DbContext = _context;
        }

        public List<UITest> GetTests()
        {
            return DbContext.Tests.Select(x => new UITest { id = x.Id, name = x.Name, time = x.MinutesForTest }).ToList();
        }

        public List<UIQuestion> GetQuestions(UITest uITest)
        {
            var s = DbContext.Tests.Include("Questions.Answers").FirstOrDefault(x => x.Id == uITest.id);
            if (s.Questions != null)
                return s.Questions.Select(x => new UIQuestion(x.QuestionText, x.Id) { MultyChoice = x.Answers.Count(y => y.IsCorrect) > 1 }).ToList();
            return new List<UIQuestion>();
        }

        public List<UIAnswer> GetAnswers(UIQuestion question)
        {
            if (question != null)
            {
                var s = DbContext.Questions.FirstOrDefault(x => x.Id == question.Id);
                if (s.Answers != null)
                    return s.Answers.Select(x => new UIAnswer(x.AnswerText, x.IsCorrect, x.Id)).ToList();
            }
            return new List<UIAnswer>();
        }

        public void SaveTest(UITest uITest)
        {
            if (uITest.id < 0)
            {
                var test = new Test(uITest.name, uITest.time);
                DbContext.Tests.Add(test);
                DbContext.SaveChanges();
            }
            else
            {
                var s = DbContext.Tests.FirstOrDefault(x => x.Id == uITest.id);
                if (s != null)
                {
                    s.Name = uITest.name;
                    s.MinutesForTest = uITest.time;
                    DbContext.SaveChanges();
                }
            }
        }

        public void SaveQuestion(UIQuestion question, UITest test)
        {
            if (question.Id < 0)
            {
                var t = DbContext.Tests.Include("Questions").FirstOrDefault(x => x.Id == test.id);
                if (t != null)
                {
                    var quest = new Question(question.QuestionText);
                    t.Questions.Add(quest);
                    DbContext.SaveChanges();
                }
            }
            else
            {
                var s = DbContext.Questions.FirstOrDefault(x => x.Id == question.Id);
                s.QuestionText = question.QuestionText;
                DbContext.SaveChanges();
            }
        }

        public void SaveAnswer(UIAnswer answer, UIQuestion question)
        {
            if (answer.Id < 0)
            {
                var t = DbContext.Questions.FirstOrDefault(x => x.Id == question.Id);
                if (t != null)
                {
                    var ans = new Answer(answer.AnswerText, answer.IsCorrect);
                    t.Answers.Add(ans);
                    DbContext.SaveChanges();
                }
            }
            else
            {
                var s = DbContext.Answers.FirstOrDefault(x => x.Id == answer.Id);
                s.AnswerText = answer.AnswerText;
                s.IsCorrect = answer.IsCorrect;
                DbContext.SaveChanges();
            }
        }

        public void DeleteTest(UITest test)
        {
            var s = DbContext.Tests.FirstOrDefault(x => x.Id == test.id);
            if (s != null)
            {
                DbContext.Tests.Remove(s);
                DbContext.SaveChanges();
            }
        }

        public void DeleteQuestion(UIQuestion question)
        {
            var s = DbContext.Questions.FirstOrDefault(x => x.Id == question.Id);
            if (s != null)
            {
                DbContext.Questions.Remove(s);
                DbContext.SaveChanges();
            }
        }

        public void DeleteAnswer(UIAnswer answer)
        {
            var s = DbContext.Answers.FirstOrDefault(x => x.Id == answer.Id);
            if (s != null)
            {
                DbContext.Answers.Remove(s);
                DbContext.SaveChanges();
            }
        }

        public Question SearchQuestion(string str)
        {
            return DbContext.Questions.FirstOrDefault(x => x.QuestionText.StartsWith(str));
        }

        public List<UIStatistics> GetStatistics()
        {
            return DbContext.TestStatistics.Select(x => new UIStatistics
            {
                TestName = x.Test.Name,
                NumberOfCorrect = x.NumberOfCorrect,
                PercentOfCorrect = x.PercentOfCorrect,
                TimeInMinutes = x.TimeInMinutes
            }).ToList();
        }

        public void SaveStatistics(UIStatistics statistics)
        {
            var t = DbContext.Tests.FirstOrDefault(x => x.Name == statistics.TestName);
            var ts = new TestStatistic
            {
                NumberOfCorrect = statistics.NumberOfCorrect,
                PercentOfCorrect = statistics.PercentOfCorrect,
                TimeInMinutes = statistics.TimeInMinutes
            };
            t.TestStatistics.Add(ts);
            DbContext.SaveChanges();
        }

        public void ClearStatistics()
        {
            DbContext.TestStatistics.RemoveRange(DbContext.TestStatistics);
            DbContext.SaveChanges();
        }
    }
}
