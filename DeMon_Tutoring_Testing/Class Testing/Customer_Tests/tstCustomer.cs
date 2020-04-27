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
        string cFirstName = "John";
        string cLastName = "Smith";
        string cDateOfBirth = DateTime.Now.Date.AddYears(16).ToString();
        string cEmail = "JohnS@Gmail.co.uk";
        string cPhoneNumber = "07345673882";
        string cPassword = "youcantseethis63";
        string cCardNo = "0544044304450444";
        string cCardDate = DateTime.Now.Date.ToString();



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

        [TestMethod]
        public void ActiveStudentStatusOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            string TestData = "yes";
            //assign the data to the Customer
            aCustomer.StudentStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.StudentStatus, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result of method
            Boolean Found = false;
            //create test data 
            int cID = 3456;
            //invoke method
            Found = aCustomer.Find(cID);
            //test to see if result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestIdNotFound()
        {
            //Creates an instance of customer 
            ClsCustomer aCustomer = new ClsCustomer();
            //boolean variable to store result method
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //creates some test data to assign to use with the method
            int cID = 728;
            //invoke the method
            Found = aCustomer.Find(cID);
            //checl the customer id number 
            if(aCustomer.CustomerID != 728)
            {
                Ok = false;
            }
            //test to check result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidMethod()
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

        [TestMethod]
        public void CustomerFirstNameEmpty()
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
        public void CustomerFirstNameMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //creating test data to pass the method
            string cFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameEmpty()
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
        public void CustomerLastNameMax()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method
            string cLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthEmpty()
        {
            //new instance of customer
            ClsCustomer aCustomer = new ClsCustomer();
            //string variable to store any error message
            string Error = "";
            //create test data to pass the method 
            string cDateOfBirth = "";
            //invoke method
            Error = aCustomer.Valid(cFirstName, cLastName, cDateOfBirth, cEmail, cPhoneNumber, cPassword, cCardNo, cCardDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
