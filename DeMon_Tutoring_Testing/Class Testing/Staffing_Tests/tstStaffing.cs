using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Staffing_Tests
{
    [TestClass]
    public class TstStaffing
    {
            //Test Data
            readonly string staffFN = "Eugene";
            readonly string staffLN = "Zuccerberg";
            readonly string staffEmail = "eugenefrisbee@gmail.com";
            readonly string staffNumber = "07974133370";
            readonly DateTime DOBConv = Convert.ToDateTime("09/08/1995");
            readonly string staffDOB = "09/08/1995";
            readonly bool staffValid = true;
      
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
        public void TestValid()
        {
            //create instance of the class we want to create
            Staffing s2 = new Staffing();
            //create some test data to assign to staff
            bool Test = true;
            //assign the data to the Staff
            s2.staffValid = Test;
            //test to see that the two values are the same
            Assert.AreEqual(Test, s2.staffValid);
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
        public void TestStaffValidFound()
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
            if (staffT.staffValid != true)
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
            //We ignore staffValid as it only can contain a boolean value
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOB);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to fail the method
            string FirstName = "";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "E";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "Eu";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "Aaaaaaaaaaaaaa";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "Aaaaaaaaaaaaaaa";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "AaaaaaaaaaaaaaaX";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "Aaaaaaaa";
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //Invoke the method
            Error = aStaff.Valid(FirstName, staffLN, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change TestDate to the date + 100 years
            TestDate = TestDate.AddYears(-100);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date - 1 days
            TestDate = TestDate.AddYears(-68).AddDays(-1);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date
            TestDate = TestDate.AddYears(-68);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinAddOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date add 1 day
            TestDate = TestDate.AddYears(-68).AddDays(1);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMaxMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date
            TestDate = TestDate.AddYears(-18).AddDays(-1);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date
            TestDate = TestDate.AddYears(-18);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxAddOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date
            TestDate = TestDate.AddYears(-18).AddDays(1);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMid()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date
            TestDate = TestDate.AddYears(-34);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            DateTime TestDate;
            //Set the date to the Minimum Date
            TestDate = DateTime.Now.Date;
            //Remove 68 years as Min Date
            TestDate = TestDate.AddYears(100);
            //Change to a string for the Valid Method
            string staffDOBTest = TestDate.ToString();
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBInvalidData()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //set StaffDOB to a non date data type
            string staffDOBTest = "this is not a date";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, staffNumber, staffDOBTest);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to fail the method
            string LastName = "";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMin()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "E";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "Eu";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "Aaaaaaaaaaaaaa";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "Aaaaaaaaaaaaaaa";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "AaaaaaaaaaaaaaaX";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "Aaaaaaaa";
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            //Invoke the method
            Error = aStaff.Valid(staffFN, LastName, staffEmail, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMinMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMin()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "0";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMinPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "01";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMaxMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "0138653910";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "01386539102";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMaxPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "013865391025";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberExtremeMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Number = "01386539102";
            Number = Number.PadRight(489, '0');
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, staffEmail, Number, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "t@";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "t@g";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "t@gm";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMaxMinusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "thomasbarnes123456@gmail.com";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "thomasbarnes1234567@gmail.com";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "thomasbarnes123456789@gmail.com";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "thoma@gmail.com";
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //Create an instance of staffing
            Staffing aStaff = new Staffing();
            //string variable to store any error message
            String Error = "";
            //Test data to pass the method
            string Email = "thomasbarnes1234567@gmail.com";
            Email = Email.PadRight(470, 'a');
            //Invoke the method
            Error = aStaff.Valid(staffFN, staffLN, Email, staffNumber, staffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddMethodOK(){
            //Create an instance of the collections class
            StaffingCollection aStaffCollection = new StaffingCollection();
            //create an instance of test data
            Staffing TestItem = new Staffing();
            //Primary key storage
            Int32 primaryKey = 0;
            //Initiate properties of test data
            TestItem.staffName = new Name("Thomas", "Barnes");
            TestItem.staffNumber = "01706844505";
            TestItem.staffEmail = "testEM@gmail.com";
            TestItem.staffDOB = Convert.ToDateTime("08/09/1990");
            TestItem.staffValid = true;
            //Set test data into collections
            aStaffCollection.ThisStaff = TestItem;
            //Add the record
            primaryKey = aStaffCollection.Add();
            //Set the primary key of the test data
            TestItem.staffID = primaryKey;
            //Find the record
            aStaffCollection.ThisStaff.Find(primaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(aStaffCollection.ThisStaff, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the collections class
            StaffingCollection aStaffCollection = new StaffingCollection();
            //create an instance of test data
            Staffing TestItem = new Staffing();
            //Primary key storage
            Int32 primaryKey = 0;
            //Initiate properties of test data
            TestItem.staffName = new Name("Thomas", "Barnes");
            TestItem.staffNumber = "01706844505";
            TestItem.staffEmail = "testEM@gmail.com";
            TestItem.staffDOB = Convert.ToDateTime("08/09/1990");
            TestItem.staffValid = true;
            //Set test data into collections
            aStaffCollection.ThisStaff = TestItem;
            //Add the record
            primaryKey = aStaffCollection.Add();
            //Set the primary key of the test data
            TestItem.staffID = primaryKey;
            //Find the record
            aStaffCollection.ThisStaff.Find(primaryKey);
            //delete the record
            aStaffCollection.Delete();
            //Find the deleted record
            Boolean Found = aStaffCollection.ThisStaff.Find(primaryKey);
            //Test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void UpdateMethodOk()
        {
            //Create an instance of the collections class
            StaffingCollection aStaffCollection = new StaffingCollection();
            //create an instance of test data
            Staffing TestItem = new Staffing();
            //Primary key storage
            Int32 primaryKey = 0;
            //Initiate properties of test data
            TestItem.staffName = new Name("Thomas", "Barnes");
            TestItem.staffNumber = "01706844505";
            TestItem.staffEmail = "testEM@gmail.com";
            TestItem.staffDOB = Convert.ToDateTime("08/09/1990");
            TestItem.staffValid = true;
            //Set test data into collections
            aStaffCollection.ThisStaff = TestItem;
            //Add the record
            primaryKey = aStaffCollection.Add();
            //Set the primary key of the test data
            TestItem.staffID = primaryKey;
            //Modify the test data
            TestItem.staffName = new Name("Update", "Worked");
            TestItem.staffNumber = "0111222222";
            TestItem.staffEmail = "thisisupdated@gmail.com";
            TestItem.staffDOB = Convert.ToDateTime("01/01/1990");
            TestItem.staffValid = false;
            //set the record based on the new data
            aStaffCollection.ThisStaff = TestItem;
            //Update the record
            aStaffCollection.Update();
            //Find the deleted record
            aStaffCollection.ThisStaff.Find(primaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(aStaffCollection.ThisStaff, TestItem);
        }
    }
}
