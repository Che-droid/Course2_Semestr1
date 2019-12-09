using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestsSeviceLib;
using Moq;
using System.Data.Entity;
using Test2;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestForTestsApplication
{
    [TestClass]
    public class QuestionMethodsTests
    {
        [TestMethod]
        public void DeleteQuestionTest()
        {
            var q = new Question("First question") { Id = 1 };
            var uiq = new UIQuestion("First question",1);
            var mockObj = TestsMethodsTests.Create(new List<Question> { q });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Questions).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);

            service.DeleteQuestion(uiq);

            mockObj.Verify(x => x.Remove(It.IsAny<Question>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void SearchQuestionTest()
        {
            var uiquest = new Question("First question") { Id = 1 };

            var mockObj = TestsMethodsTests.Create(new List<Question> { uiquest });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Questions).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);
            var q = service.SearchQuestion("First");

            Assert.AreEqual(uiquest, q);
        }
    }
}
