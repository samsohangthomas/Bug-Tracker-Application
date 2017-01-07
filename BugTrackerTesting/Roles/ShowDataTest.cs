using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;
namespace BugTrackerTesting.Roles
{
    [TestClass]
    public class ShowDataTest
    {
        [TestMethod]
        public void TestShowData()
        {
            bool expected = true;
            bool result;

            Role roleModel = new Role();
            result = roleModel.showData(1);
            Assert.AreEqual(expected, result);
        }
    }
}
