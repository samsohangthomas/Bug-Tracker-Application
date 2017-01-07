using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.BugSolutions
{
    [TestClass]
    public class UpdateTest
    {
        [TestMethod]
        public void TestUpdate()
        {
            BugSolution bugsolnModel = new BugSolution();

            int bug_id = 12;
            string fixed_code = "Updated Debugging Test Source";


            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            bugsolnModel.setAttributes(bug_id, fixed_code);
            result = bugsolnModel.update(3);

            Assert.AreEqual(expected, result);
        }
    }
}
