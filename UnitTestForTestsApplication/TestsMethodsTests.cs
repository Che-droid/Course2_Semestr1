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
    public class TestsMethodsTests
    {
        public static Mock<DbSet<T>> Create<T>(IEnumerable<T> data) where T : class
        {
            var queryable = data.AsQueryable();
            var mock = new Mock<DbSet<T>>();
            mock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            return mock;
        }

        [TestMethod]
        public void AddTest()
        {
            var uitest = new UITest("First test", 5);

            var mockObj = new Mock<DbSet<Test>>();

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Tests).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);
            service.SaveTest(uitest);

            mockObj.Verify(m => m.Add(It.IsAny<Test>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void EditTest()
        {
            var mockObj = Create(new List<Test> { new Test("First test", 5) { Id = 1 } });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Tests).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);

            var list = service.GetTests();
            Assert.IsTrue(list.Count == 1);

            list[0].time = 20;

            service.SaveTest(list[0]);

            var list2 = service.GetTests();
            Assert.IsTrue(list2.Count == 1);

            Assert.AreEqual(20, list2[0].time);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetTestsTest()
        {
            var mockObj = Create(new List<Test> { new Test("First test", 5) { Id = 1 } });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Tests).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);

            var list = service.GetTests();

            Assert.IsTrue(list.Count == 1);
            Assert.AreEqual(1, list[0].id);
        }

        [TestMethod]
        public void DeleteTestTest()
        {
            var mockObj = Create(new List<Test> { new Test("First test", 5) { Id = 1 } });

            var mockContext = new Mock<Test2DBContainer>();
            mockContext.Setup(m => m.Tests).Returns(mockObj.Object);

            var service = new Service(mockContext.Object);

            var list = service.GetTests();
            service.DeleteTest(list[0]);

            mockObj.Verify(x => x.Remove(It.IsAny<Test>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

    }
}
