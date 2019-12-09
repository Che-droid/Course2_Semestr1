using Moq;
using System.Data.Entity;
using Test2;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestsSeviceLib;

namespace UnitTestForTestsApplication
{
    [TestClass]
    public class AnswersMethodsTests
    {
        [TestMethod]
        public void EditAnswer()
        {
            var uiq = new UIQuestion("First question", 1);
            var q = new Question("First question") { Id = 1 };
            var uians = new UIAnswer("First answer", true, 1);
            var ans = new Answer("First answer", true) { Id = 1 };

            var mockObj = TestsMethodsTests.Create(new List<Question> { q });
            var mockObjA = TestsMethodsTests.Create(new List<Answer> { ans });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Questions).Returns(mockObj.Object);
            mockContext.Setup(m => m.Answers).Returns(mockObjA.Object);

            var service = new Service(mockContext.Object);

            service.SaveAnswer(uians, uiq);

            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetAnswersTest()
        {
            var uians = new UIAnswer("First answer", true, 1);
            var ans = new Answer("First answer", true) { Id = 1 };
            var uiq = new UIQuestion("First question", 1);
            var q = new Question("First question") { Id = 1, Answers = new List<Answer> { ans } };


            var mockObj = TestsMethodsTests.Create(new List<Question> { q });
            var mockObjA = TestsMethodsTests.Create(new List<Answer> { ans });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Questions).Returns(mockObj.Object);
            mockContext.Setup(m => m.Answers).Returns(mockObjA.Object);

            var service = new Service(mockContext.Object);

            var list = service.GetAnswers(uiq);

            Assert.IsTrue(list.Count == 1);
            Assert.AreEqual(1, list[0].Id);
        }

        [TestMethod]
        public void DeleteAnswerTest()
        {
            var uians = new UIAnswer("First test", true, 1);
            var ans = new Answer("First test", true) { Id = 1 };

            var mockObj = TestsMethodsTests.Create(new List<Answer> { ans });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Answers).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);

            service.DeleteAnswer(uians);

            mockObj.Verify(x => x.Remove(It.IsAny<Answer>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }


        [TestMethod]
        public void GetStatisticsTest()
        {
            var ts = new TestStatistic { Id = 1, NumberOfCorrect = 2, PercentOfCorrect = 50, Test = new Test(), TimeInMinutes = 1 };

            var mockObj = TestsMethodsTests.Create(new List<TestStatistic> { ts });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.TestStatistics).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);
            var list = service.GetStatistics();

            Assert.IsTrue(list.Count == 1);
            Assert.AreEqual(2, list[0].NumberOfCorrect);
        }

        [TestMethod]
        public void SaveStatisticsTest()
        {
            var test = new Test { Name = "First test" };
            var uits = new UIStatistics { NumberOfCorrect = 2, PercentOfCorrect = 50, TestName = "First test", TimeInMinutes = 1 };

            var mockObj = TestsMethodsTests.Create(new List<TestStatistic>());
            var mockT = TestsMethodsTests.Create(new List<Test> { test });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.TestStatistics).Returns(mockObj.Object);
            mockContext.Setup(m => m.Tests).Returns(mockT.Object);

            var service = new Service(mockContext.Object);
            service.SaveStatistics(uits);

            //mockObj.Verify(m => m.Add(It.IsAny<TestStatistic>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void ClearStatisticsTest()
        {
            var ts = new TestStatistic { Id = 1, NumberOfCorrect = 2, PercentOfCorrect = 50, Test = new Test(), TimeInMinutes = 1 };

            var ent = new List<TestStatistic> { ts };

            var mockObj = TestsMethodsTests.Create(ent);

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.TestStatistics).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);
            service.ClearStatistics();

            var list = service.GetStatistics();

            //mockObj.Verify(x => x.RemoveRange(ent), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
