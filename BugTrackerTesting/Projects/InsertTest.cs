using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.Projects
{
    [TestClass]
    public class InsertTest
    {
        [TestMethod]
        public void TestInsert() {

            Project projectModel = new Project();         
            string name = "Ruby and Rails Bug";
            string description = "Debugging problem";


            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            projectModel.setAttributes(name,description);
            result = projectModel.insert();

            Assert.AreEqual(expected, result);


        }
    }
}
