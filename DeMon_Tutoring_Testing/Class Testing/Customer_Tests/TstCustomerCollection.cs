using DeMon_Tutoring_Classes.Customer_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Testing.Class_Testing.Customer_Tests
{
    [TestClass]
    public class TstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void AddressListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();


            List<ClsCustomer> TestList = new List<ClsCustomer>();

            ClsCustomer TestItem = new ClsCustomer();
            Name cName = new Name("Dale", "Doback");

            TestItem.CustomerID = 5;
            TestItem.CustomerName = cName;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Email = "dude@123.Yahoo.co.uk";
            TestItem.PhoneNumber = "00009278362";
            TestItem.Password = "12345678910";
            TestItem.CardNo = "0202983729182916";
            TestItem.CardDate = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            ClsCustomer TestCustomer = new ClsCustomer();
            Name cName = new Name("Dale", "Doback");

            TestCustomer.CustomerID = 5;
            TestCustomer.CustomerName = cName;
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.Email = "dude@123.Yahoo.co.uk";
            TestCustomer.PhoneNumber = "00009278362";
            TestCustomer.Password = "12345678910";
            TestCustomer.CardNo = "0202983729182916";
            TestCustomer.CardDate = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();


            List<ClsCustomer> TestList = new List<ClsCustomer>();

            ClsCustomer TestItem = new ClsCustomer();
            Name cName = new Name("Dale", "Doback");

            TestItem.CustomerID = 5;
            TestItem.CustomerName = cName;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Email = "dude@123.Yahoo.co.uk";
            TestItem.PhoneNumber = "00009278362";
            TestItem.Password = "password";
            TestItem.CardNo = "0202983729182916";
            TestItem.CardDate = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            ClsCustomer TestItem = new ClsCustomer();
            Name cName = new Name("Dale", "Doback");

            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.CustomerName = cName;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Email = "dude@123.Yahoo.co.uk";
            TestItem.PhoneNumber = "00009278362";
            TestItem.Password = "Passssss";
            TestItem.CardNo = "0202983729182916";
            TestItem.CardDate = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            ClsCustomer TestItem = new ClsCustomer();
            Name cName = new Name("Dale", "Doback");

            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.CustomerName = cName;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Email = "dude@123.Yahoo.co.uk";
            TestItem.PhoneNumber = "00009278362";
            TestItem.Password = "Passssss";
            TestItem.CardNo = "0202983729182916";
            TestItem.CardDate = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            ClsCustomer TestItem = new ClsCustomer();
            Name cName = new Name("Dale", "Doback");

            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.CustomerName = cName;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Email = "dude@123.Yahoo.co.uk";
            TestItem.PhoneNumber = "00009278362";
            TestItem.Password = "Passssss";
            TestItem.CardNo = "0202983729182916";
            TestItem.CardDate = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerID = PrimaryKey;

            TestItem.CustomerID = 3;
            TestItem.CustomerName = cName;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Email = "dude@456.Yahoo.co.uk";
            TestItem.PhoneNumber = "00009278387";
            TestItem.Password = "egg";
            TestItem.CardNo = "0202983729182814";
            TestItem.CardDate = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            AllCustomers.Update();

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportyByEmailMethodOK()
        {

            clsCustomerCollection FilteredEmails = new clsCustomerCollection();

            FilteredEmails.ReportByEmail("xxxxxxxx");

            Assert.AreEqual(0, FilteredEmails.Count);
        }

       /* [TestMethod]
        public void ReportByEmailTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            Boolean OK = true;

            FilteredCustomers.ReportByEmail("dude@123.Yahoo.co.uk");

            if(FilteredCustomers.Count == 2)
            {

                if (FilteredCustomers.CustomerList[0].CustomerID != 4)
                {
                    OK = false;
                }

                if (FilteredCustomers.CustomerList[1].CustomerID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }*/

    }
}
