using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core.AesEnc;

namespace BugTrackerTesting.User
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestLogin()
        {
            string email = "kritim@gmail.com";
            string password = AesCryp.Encrypt("thehelp#");

            bool expected = true;
            bool result;

            Users userModel = new Users();
            result = userModel.authenticateUser(email, password);
            Assert.AreEqual(expected, result);
        }
    }
}
