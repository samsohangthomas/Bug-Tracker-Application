using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.BugSolutions
{
    [TestClass]
    public class DeleteTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            BugSolution bugsoln = new BugSolution();
            result = bugsoln.delete(3);
            Assert.AreEqual(expected, result);

        }
    }
}
