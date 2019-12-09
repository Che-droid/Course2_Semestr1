using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public partial class Test
    {
        public Test(string name, int timeForTest)
        {
            Name = name;
            MinutesForTest = timeForTest;
        }
    }

    public partial class Question
    {
        public Question(string str)
        {
            QuestionText = str;
        }
    }

    public partial class Answer
    {
        public Answer()
        {
        }

        public Answer(string answerText, bool isCorrect)
        {
            AnswerText = answerText;
            IsCorrect = isCorrect;
        }
    }
}
