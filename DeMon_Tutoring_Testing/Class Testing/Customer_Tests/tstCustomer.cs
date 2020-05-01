using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Customer_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
namespace DeMon_Tutoring_Testing
{
    [TestClass]
    public class tstCustomer
    {

        //test data for the validation method
       readonly string cFirstName = "Gordon";
       readonly string cLastName = "Smith";
       readonly string cDateOfBirth = "25/12/2000";
       readonly string cEmail = "gordo@yahoo";
       readonly string cPhoneNumber = "8888";
       readonly string cPassword = "guitar";
       readonly string cCardNo = "1455275255785532";
       readonly string cCardDate = "24/07/2023";



        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //<<<<<<<<< Temporary merge branch 1
            //test to see that it now exist
            Assert.IsNotNull(aCustomer);
        }
      

        [TestMethod]
        public void CustomerNameOk()
        {
            //Create an instance of name and Customer
            Name n1 = new Name("Dale", "Doback");
            ClsCustomer s1 = new ClsCustomer();
            //Insert the test name
            s1. CustomerName = n1;
            //Compare if equal
            Assert.AreEqual(n1, s1.CustomerName);

        }

        [TestMethod]
        public void ActiveDateOfBirthOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            DateTime TestData = DateTime.Today;
            //assign the data to the Customer
            aCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateOfBirth, TestData);

        }

        [TestMethod]
        public void ActiveEmailAddressOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            String TestData = "DaleDo@Gmail.co.uk";
            //assign the data to the Customer
            aCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Email, TestData);

        }

        [TestMethod]
        public void ActivePhoneNumberOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            String TestData = "07784533627";
            //assign the data to the Customer
            aCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.PhoneNumber, TestData);

        }

        [TestMethod]
        public void ActivePasswordOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            String TestData = "Password123";
            //assign the data to the Customer
            aCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Password, TestData);

        }

        [TestMethod]
        public void ActiveCardNumberOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            String TestData = "3554 3773 2281 1839";
            //assign the data to the Customer
            aCustomer.CardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CardNo, TestData);
        }

        [TestMethod]
        public void ActiveCardDateOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            DateTime TestData = DateTime.Today;
            //assign the data to the Customer
            aCustomer.CardDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CardDate, TestData);
        }

        //-------------------------Find Method Testing---------------------------

        [TestMethod]
        public void FindMethodOk()
        {
            //create new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result of method
            Boolean Found = false;
            //create test data 
            Int32 CustomerID = 2;
            //invoke method
            Found = aCustomer.Find(CustomerID);
            //test to see if result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerNotFound()
        {
            //Creates an instance of customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID =2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer id number 
            if(aCustomer.CustomerID != 2)
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerNameFound()
        {
            //create new customer and new name 
            Name cName = new Name("Gordon", "Smith");
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.CustomerName.getFullName() != cName.getFullName())
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerDOBFound()
        {
            //create new customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.DateOfBirth != Convert.ToDateTime("25/12/2000"))
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerEmailFound()
        {
            //create new customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.Email != "gordo@yahoo")
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerPhoneNumberFound()
        {
            //create new customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.PhoneNumber != "8888")
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerPasswordFound()
        {
            //create new customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.Password != "guitar")
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void CustomerCardNoFound()
        {
            //create new customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.CardNo != "1455275255785532")
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerCardDateFound()
        {
            //create new customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            Int32 cID = 2;
            //invoke the method
            Found = aCustomer.Find(cID);
            //check the customer name
            if (aCustomer.CardDate != Convert.ToDateTime("24/07/2023"))
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        //---------------------Validation Tests-----------------------------

        [TestMethod]
        public void ValidMethodOk()
        {
            //creates an instamce of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //invoke method 

            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //--------------FirstName Validation Tests----------------------------

        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "a";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "ah";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "";
            cFirstName = cFirstName.PadRight(24, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "";
            cFirstName = cFirstName.PadRight(25, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "";
            cFirstName = cFirstName.PadRight(26, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "";
            cFirstName = cFirstName.PadRight(12, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "";
            cFirstName = cFirstName.PadRight(500, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //-----------------LastName Validation Tests--------------------

        [TestMethod]
        public void CustomerLastNameaMinMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cLastName = "";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cLastName = "a";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cLastName = "ah";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cLastName = "";
            cLastName = cLastName.PadRight(24, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cLastName = "";
            cLastName = cLastName.PadRight(25, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cLastName = "";
            cLastName = cLastName.PadRight(26, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMid()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cLastName = "";
            cLastName = cLastName.PadRight(12, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameExtremeMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cLastName = "";
            cLastName = cLastName.PadRight(500, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //------------------Test Mehtods for DateOfBirth Validation--------------

        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerDOB;

            customerDOB = DateTime.Now.Date;

            customerDOB = customerDOB.AddYears(-100);

            string cDateOfBirth = customerDOB.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerDOB;

            customerDOB = DateTime.Now.Date;

            customerDOB = customerDOB.AddDays(-1);

            string cDateOfBirth = customerDOB.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerDOB;

            customerDOB = DateTime.Now.Date;

            string cDateOfBirth = customerDOB.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerDOB;

            customerDOB = DateTime.Now.Date;

            customerDOB = customerDOB.AddDays(1);

            string cDateOfBirth = customerDOB.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerDOB;

            customerDOB = DateTime.Now.Date;

            customerDOB = customerDOB.AddYears(100);

            string cDateOfBirth = customerDOB.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthInvalidDate()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cDateOfBirth = "not a date";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //----------------Validation Tests for Email------------------

        [TestMethod]
        public void CustomerEmailMinMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cEmail = "aaaa";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cEmail = "aaaaa";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cEmail = "aaaaaa";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cEmail = "";
            cEmail = cEmail.PadRight(49, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cEmail = "";
            cEmail = cEmail.PadRight(50, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cEmail = "";
            cEmail = cEmail.PadRight(51, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMid()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cEmail = "";
            cEmail = cEmail.PadRight(25, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cEmail = "";
            cEmail = cEmail.PadRight(500, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---------------Validation Tests for PhoneNumber--------------

        [TestMethod]
        public void CustomerPhoneNumberMinMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cPhoneNumber = "1235678910";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPhoneNumberMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cPhoneNumber = "123456789101";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cPhoneNumber = "1234567891011";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberAllowedNull()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cPhoneNumber = "";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //------------------Validation Tests for Password-------------

        [TestMethod]
        public void CustomerPasswordLessOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "a";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPasswordMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "ah";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "";
            cPassword = cPassword.PadRight(24, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "";
            cPassword = cPassword.PadRight(25, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "";
            cPassword = cPassword.PadRight(26, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "";
            cPassword = cPassword.PadRight(12, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPasswordExtremeMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cPassword = "";
            cPassword = cPassword.PadRight(500, 'a');
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //-------------Validation For Card Number---------------------

        [TestMethod]
        public void CustomerCardNoMinMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cCardNo = "12356789101234";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerCardNoMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cCardNo = "1234567891012345";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardNoMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cCardNo = "12345678910123456";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---------------Validation Testing for Card Date-------------------

        [TestMethod]
        public void CustomerCardDateExtremeMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerCardDate;

            customerCardDate = DateTime.Now.Date;

            customerCardDate = customerCardDate.AddYears(-100);

            string cCardDate = customerCardDate.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardDateMinMinusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerCardDate;

            customerCardDate = DateTime.Now.Date;

            customerCardDate = customerCardDate.AddDays(-1);

            string cCardDate = customerCardDate.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardDateMin()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerCardDate;

            customerCardDate = DateTime.Now.Date;

            string cCardDate = customerCardDate.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardDateMinPlusOne()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerCardDate;

            customerCardDate = DateTime.Now.Date;

            customerCardDate = customerCardDate.AddDays(1);

            string cCardDate = customerCardDate.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardDateExtremeMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            DateTime customerCardDate;

            customerCardDate = DateTime.Now.Date;

            customerCardDate = customerCardDate.AddYears(100);

            string cCardDate = customerCardDate.ToString();
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardDateInvalidDate()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cCardDate = "not a date";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
