using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;
using bugtracker.core.AesEnc;
namespace BugTrackerTesting.User
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

            Users userModel = new Users();
            result = userModel.delete(16);
            Assert.AreEqual(expected, result);
        }
    }
}
