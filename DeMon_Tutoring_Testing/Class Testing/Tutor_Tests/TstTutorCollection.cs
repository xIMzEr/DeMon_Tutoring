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
            TestItem.tutorName = new Name("some", "some");
            TestItem.tutorEmail = "some@some.co.uk";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678";
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
            clsTutor TestTutor = new clsTutor();
            //set the properties of the test object
            TestTutor.tutorAvailabe = true;
            TestTutor.tutorId = 1;
            TestTutor.tutorName = new Name("some", "some");
            TestTutor.tutorEmail = "some@some.co.uk";
            TestTutor.tutorSubject = "Chemistry";
            TestTutor.tutorPassword = "12345678";
            TestTutor.tutorDateAdded = DateTime.Now.Date;

            //assign the data to the property
            AllTutors.ThisTutor = TestTutor;
            //test to see that the two values are the same
            Assert.AreEqual(AllTutors.ThisTutor, TestTutor);
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
            TestItem.tutorName = new Name("some", "some");
            TestItem.tutorEmail = "some@some.co.uk";
            TestItem.tutorSubject = "Chemistry";
            TestItem.tutorPassword = "12345678";
            TestItem.tutorDateAdded = DateTime.Now.Date;

            //add the item to the list
            TestList.Add(TestItem);

            //assign the data to the property
            AllTutors.TutorList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllTutors.Count, TestList.Count);
        }

       
    }
}
