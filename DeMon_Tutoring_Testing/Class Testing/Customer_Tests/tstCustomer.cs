using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Customer_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
namespace DeMon_Tutoring_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //test to see that it now exist
            Assert.IsNotNull(aCustomer);

        }

        [TestMethod]
        public void ActiveCustomerIDOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            bool TestData = true;

            //assign the data to the Customer

            //YOU HAVE REMOVED THE ACTIVE FIELD FROM CUSTOMER

            //aCustomer.Active = TestData;
            //test to see that the two values are the same
            //Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void ActiveCustomerOk()
        {
            //create instance of the class we want to create
            ClsCustomer aCustomer = new ClsCustomer();
            //create some test data to assign to Customer
            Boolean TestData = true;

            //YOU HAVE REMOVED THE ACTIVE FIELD FROM CUSTOMER X2

            //assign the data to the Customer
            //aCustomer.Active = TestData;
            //test to see that the two values are the same
            //Assert.AreEqual(aCustomer.Active, TestData);

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
            string TestData = "11 / 11 / 11";
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
            string TestData = "11 / 11 / 11";
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
            ClsCustomer aCustomer = new ClsCustomer();

            Boolean Found = false;

            Boolean Ok = true;

            int cID = 728;

            Found = aCustomer.Find(cID);

            if(aCustomer.CustomerID != 728)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }


    }
}
