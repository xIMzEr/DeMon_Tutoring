using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Staffing_Tests
{
    [TestClass]
    public class tstStaffing
    {
            //Test Data
            string staffFN = "Eugene";
            string staffLN = "Zuccerberg";
            string staffEmail = "eugenefrisbee@gmail.com";
            string staffNumber = "07974133370";
            DateTime DOBConv = Convert.ToDateTime("09/08/1995");
            string staffDOB = DOBConv.ToString();
      
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
            //create some test data to assign to staff
            int Test = 1;
            //assign the data to the Staff
            s2.staffID = Test;
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.staffID);
        }

        [TestMethod]
        public void TestName()
        {
            //Create an instance of name and staffing
            Name n1 = new Name("Jimmy", "McBro");
            Staffing s1 = new Staffing();
            //Insert the test name
            s1.staffName = n1;
            //Compare if equal
            Assert.AreEqual(n1, s1.staffName);
        }

        [TestMethod]
        public void TestEmail()
        {
            //create instance of the class we want to create
            Staffing s2 = new Staffing();
            //create some test data to assign to tutor
            string Test = "myname@gmail.com";
            //assign the data to the Staff
            s2.staffEmail = Test;
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.staffEmail);
        }

        [TestMethod]
        public void TestNumber()
        {
            //create instance of the class we want to create
            Staffing s2 = new Staffing();
            //create some test data to assign to staff
            string Test = "01706844505";
            //assign the data to the Staff
            s2.staffNumber = Test;
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.staffNumber);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of Staffing
            Staffing staffT = new Staffing();
            //Boolean varibable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 staffID = 14;
            //Invoke the method
            Found = staffT.Find(staffID);
            //Test to see if ther esult is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //Create an instance of Staffing
            Staffing staffT = new Staffing();
            //Boolean varibable to store the result of the validation
            Boolean Found = false;
            //Bool to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffID = 14;
            //Invoke the method
            Found = staffT.Find(StaffID);

            //Check the staffID against the test ID
            if(staffT.staffID != 14)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //Create an instance of Staffing
            Name staffN = new Name("Eugene", "Zuccerberg");
            Staffing staffT = new Staffing();
            //Boolean varibable to store the result of the validation
            Boolean Found = false;
            //Bool to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffID = 14;
            //Invoke the method
            Found = staffT.Find(StaffID);

            //Grab the full name and compare it to what should be found
            if (staffT.staffName.getFullName() != staffN.getFullName())
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //Create an instance of Staffing
            Staffing staffT = new Staffing();
            //Boolean varibable to store the result of the validation
            Boolean Found = false;
            //Bool to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffID = 14;
            //Invoke the method
            Found = staffT.Find(StaffID);

            //Check the staffEmail value against what should be found
            if (staffT.staffEmail != "eugenefrisbee@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNumberFound()
        {
            //Create an instance of Staffing
            Staffing staffT = new Staffing();
            //Boolean varibable to store the result of the validation
            Boolean Found = false;
            //Bool to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffID = 14;
            //Invoke the method
            Found = staffT.Find(StaffID);

            //Check the stafNumber value against what should be found
            if (staffT.staffNumber != "07974133370")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            //Create an instance of Staffing
            Staffing staffT = new Staffing();
            //Boolean varibable to store the result of the validation
            Boolean Found = false;
            //Bool to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffID = 14;
            //Invoke the method
            Found = staffT.Find(StaffID);

            //Check the stafDOB value against what should be found
            if (staffT.staffDOB != Convert.ToDateTime("09/08/1995"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of staff
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOB);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
