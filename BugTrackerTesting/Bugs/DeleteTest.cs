using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;
using bugtracker.core.AesEnc;
namespace BugTrackerTesting.Bugs
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

            Bug bugModel = new Bug();
            result = bugModel.delete(12);
            Assert.AreEqual(expected, result);
        }
    }
}
