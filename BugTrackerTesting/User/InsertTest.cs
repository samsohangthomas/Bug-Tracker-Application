using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;
using bugtracker.core.AesEnc;

namespace BugTrackerTesting.User
{
    [TestClass]
    public class InsertTest
    {
        [TestMethod]

        // registering 
        public void TestInsert()
        {
            Users userModel = new Users();
            string full_name = "Ramesh Shrestha";
            string gender = "Male";
            string email = "ramesh@gmail.com";
            int role_id = 2;
            string password = AesCryp.Encrypt("thehelp#");


            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            userModel.setAttributes(full_name,gender,email,role_id);
            userModel.setPassword(password);
            result = userModel.register();

            Assert.AreEqual(expected, result);

        }
    }
}
