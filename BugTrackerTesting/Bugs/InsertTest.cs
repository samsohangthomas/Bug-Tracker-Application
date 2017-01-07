using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bugtracker.Model;
using bugtracker.core;

namespace BugTrackerTesting.Bugs
{
    [TestClass]
    public class InsertTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            Bug bugModel = new Bug();

            int project_id =1;
            int dev_tester_id =3;
            string line_of_code = "0 - 5";
            string file_class = "Test Class";
            string method = "Test Method";
            string source_code = "Test Source";


            bool expected = true;
            bool result;
            QueryBuilder.testMode = true;

            bugModel.setAttributes(project_id,dev_tester_id,line_of_code,file_class,method,source_code);
            result = bugModel.report();

            Assert.AreEqual(expected, result);
        }
    }
}
