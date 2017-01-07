using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.BugSolutions
{
    [TestClass]
    public class InsertTest
    {
        [TestMethod]
        public void TestInsert()
        {

            BugSolution bugsolnModel = new BugSolution();

            int  bug_id = 12;
            string fixed_code = "Debugging Test Source";


            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            bugsolnModel.setAttributes(bug_id, fixed_code);
            result = bugsolnModel.fixinsert();

            Assert.AreEqual(expected, result);
        }
    }
}
