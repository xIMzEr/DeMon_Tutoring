using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Staffing_Tests
{
    [TestClass]
    public class tstStaffing
    {
        [TestMethod]
        public void AssertNotNull()
        {
            //create instance of the class we want to create
            Staffing s1 = new Staffing();
            //test to see that it now exists
            Assert.IsNotNull(s1);
           
        }

        [TestMethod]
        public void TestID()
        {
            //create instance of the class we want to create
            Staffing s2 = new Staffing();
            //create some test data to assign to tutor
            int Test = 1;
            //assign the data to the Staff
            s2.setID(Test);
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.getID());
        }

        [TestMethod]
        public void TestName()
        {
            //Create an instance of name and staffing
            Name n1 = new Name("Jimmy", "McBro");
            Staffing s1 = new Staffing();
            //Insert the test name
            s1.setName(n1);
            //Compare if equal
            Assert.AreEqual(n1, s1.getName());
        }

        [TestMethod]
        public void TestEmail()
        {
            //create instance of the class we want to create
            Staffing s2 = new Staffing();
            //create some test data to assign to tutor
            string Test = "myname@gmail.com";
            //assign the data to the Staff
            s2.setEmail(Test);
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.getEmail());
        }

        [TestMethod]
        public void TestNumber()
        {
            //create instance of the class we want to create
            Staffing s2 = new Staffing();
            //create some test data to assign to tutor
            string Test = "01706844505";
            //assign the data to the Staff
            s2.setNumber(Test);
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.getNumber());
        }
    }
}
