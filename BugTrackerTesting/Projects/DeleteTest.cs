using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.Projects
{
    [TestClass]
    public class DeleteTest
    {
        [TestMethod]
        public void TestDelete()
        {

            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            Project projectModel = new Project();
            result = projectModel.delete(3);
            Assert.AreEqual(expected, result);
        }
    }
}
