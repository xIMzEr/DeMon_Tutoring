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
            clsCustomer aCustomer = new clsCustomer();
            //test to see that it now exist
            Assert.IsNotNull(aCustomer);

        }

        [TestMethod]
        public void ActiveCustomerIDOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            bool TestData = true;
            //assign the data to the tutor
            aCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void ActiveCustomerOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Active, TestData);

        }
        [TestMethod]
        public void ActiveNameCustomer()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            Name TestData = new Name("Dale", "Doback");
            //assign the data to the tutor
            aCustomer.setName(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.getName(), TestData);
        }

        [TestMethod]
        public void ActiveDateOfBirthOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            string TestData = "11 / 11 / 11";
            //assign the data to the tutor
            aCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateOfBirth, TestData);

        }

        [TestMethod]
        public void ActiveEmailAddressOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            String TestData = "DaleDo@Gmail.co.uk";
            //assign the data to the tutor
            aCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Email, TestData);

        }

        [TestMethod]
        public void ActivePhoneNumberOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            String TestData = "07784533627";
            //assign the data to the tutor
            aCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.PhoneNumber, TestData);

        }

        [TestMethod]
        public void ActivePasswordOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            String TestData = "Password123";
            //assign the data to the tutor
            aCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Password, TestData);

        }

        [TestMethod]
        public void ActiveCardNumberOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            String TestData = "3554 3773 2281 1839";
            //assign the data to the tutor
            aCustomer.CardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CardNo, TestData);
        }

        [TestMethod]
        public void ActiveCardDateOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            string TestData = "11 / 11 / 11";
            //assign the data to the tutor
            aCustomer.CardDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CardDate, TestData);
        }

        [TestMethod]
        public void ActiveStudentStatusOk()
        {
            //create instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aCustomer.StudentStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.StudentStatus, TestData);
        }
    }
}
