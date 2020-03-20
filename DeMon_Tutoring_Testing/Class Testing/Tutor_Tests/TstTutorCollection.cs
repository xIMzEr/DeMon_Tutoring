using System;
using DeMon_Tutoring_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Tutor_Tests
{
    [TestClass]
    public class TstTutorCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTutors);
        }

        [TestMethod]
        public void AddressListOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsTutor> TestList = new List<clsTutor>();
            //add an item to the list
            //create the item of the test data
            clsTutor TestItem = new clsTutor();

            //set its properties
            TestItem.tutorAvailabe = true;
            TestItem.tutorId = 1;
            TestItem.tutorFirstName = "Bob";
            TestItem.tutorLastName = "Bob";
            TestItem.tutorEmail = "bobstevens@123.kdas.com";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678910";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTutors.TutorList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllTutors.TutorList, TestList);
        }

        

        [TestMethod]
        public void ThisTutorPropertyOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create some test data to assign to the property
            clsTutor TestItem = new clsTutor();
            //set the properties of the test object
            TestItem.tutorAvailabe = true;
            TestItem.tutorId = 1;
            TestItem.tutorFirstName = "Bob";
            TestItem.tutorLastName = "Bob";
            TestItem.tutorEmail = "bobstevens@123.kdas.com";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678910";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //assign the data to the property
            AllTutors.ThisTutor = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllTutors.ThisTutor, TestItem);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsTutor> TestList = new List<clsTutor>();
            //add an item to the list
            //create the item of test data
            clsTutor TestItem = new clsTutor();

            //set the properties of the test object
            TestItem.tutorAvailabe = true;
            TestItem.tutorId = 1;
            TestItem.tutorFirstName = "Bob";
            TestItem.tutorLastName = "Bob";
            TestItem.tutorEmail = "bobstevens@123.kdas.com";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678910";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //add the item to the list
            TestList.Add(TestItem);

            //assign the data to the property
            AllTutors.TutorList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllTutors.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create the tem of test data
            clsTutor TestItem = new clsTutor();
            //variable to store the primary key
            Int32 PrimaryKey = 0;


            //set the properties of the test object
            TestItem.tutorAvailabe = true;
            TestItem.tutorId = 1;
            TestItem.tutorFirstName = "Bob";
            TestItem.tutorLastName = "Bob";
            TestItem.tutorEmail = "bobstevens@123.kdas.com";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678910";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //set ThisTutor to the test data
            AllTutors.ThisTutor = TestItem;
            //add the record
            PrimaryKey = AllTutors.Add();
            //set the primary key of the test data
            TestItem.tutorId = PrimaryKey;
            //find the record
            AllTutors.ThisTutor.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllTutors.ThisTutor, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create the tem of test data
            clsTutor TestItem = new clsTutor();
            //variable to store the primary key
            Int32 PrimaryKey = 0;


            //set the properties of the test object
            TestItem.tutorAvailabe = true;
            TestItem.tutorId = 1;
            TestItem.tutorFirstName = "Bob";
            TestItem.tutorLastName = "Bob";
            TestItem.tutorEmail = "bobstevens@123.kdas.com";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678910";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //set ThisTutor to the test data
            AllTutors.ThisTutor = TestItem;
            //add the record
            PrimaryKey = AllTutors.Add();
            //set the primary key of the test data
            TestItem.tutorId = PrimaryKey;
            //find the record
            AllTutors.ThisTutor.Find(PrimaryKey);
            //delete this record
            AllTutors.Delete();
            //now find the record
            Boolean Found = AllTutors.ThisTutor.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create the tem of test data
            clsTutor TestItem = new clsTutor();
            //variable to store the primary key
            Int32 PrimaryKey = 0;


            //set the properties of the test object
            TestItem.tutorAvailabe = true;
            TestItem.tutorId = 1;
            TestItem.tutorFirstName = "Bob";
            TestItem.tutorLastName = "Bob";
            TestItem.tutorEmail = "bobstevens@123.kdas.com";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678910";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //set ThisTutor to the test data
            AllTutors.ThisTutor = TestItem;
            //update the record
            AllTutors.Update();
            //find the record
            AllTutors.ThisTutor.Find(PrimaryKey);
            //test to see if ThisTutor matches the test data
            Assert.AreEqual(AllTutors.ThisTutor, TestItem);
        }

        [TestMethod]
        public void ReportBySubjectMethodOk()
        {
            //create an instance of the class we want to create
            clsTutorCollection AllTutors = new clsTutorCollection();
            //create an instance of the filtered data
            clsTutorCollection FilteredTutors = new clsTutorCollection();
            //apply a blank string (should return all records)
            FilteredTutors.ReportBySubject("");
            //test to see that the two values are the same
            Assert.AreEqual(AllTutors.Count, FilteredTutors.Count);
        }

        [TestMethod]
        public void ReportBySubject(string Subject)
        {
            //create an instance of the filtered data
            clsTutorCollection FilteredTutors = new clsTutorCollection();
            //apply an email that doesn't exist
            FilteredTutors.ReportBySubject("not a subject");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredTutors.Count);
        }



    }
}
