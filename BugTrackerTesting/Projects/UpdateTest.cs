using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.Projects
{
    [TestClass]
    public class UpdateTest
    {
        [TestMethod]
        public void TestUpdate()
        {
            Project project = new Project();
            string name = "Ruby and Rails Bug";
            string description = "Debugging bug on ruby";


            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            project.setAttributes(name,description);
            result = project.update(2);

            Assert.AreEqual(expected, result);
        }
    }
}
