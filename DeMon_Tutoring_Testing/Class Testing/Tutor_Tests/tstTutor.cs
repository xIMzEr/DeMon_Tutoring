using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Tutor_Tests
{
    [TestClass]
    public class tstTutor
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //test to see that it now exists
            Assert.IsNotNull(aTutor);
   
        }

        [TestMethod]
        public void ActiveTutorOk()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aTutor.active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.active, TestData);
        }

        [TestMethod]
        public void ActiveIdTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            int TestData = 1;
            //assign the data to the tutor
            aTutor.tutorId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorId, TestData);
        }

        [TestMethod]
        public void ActiveFirstNameTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Bob";
            //assign the data to the tutor
            aTutor.firstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.firstName, TestData);
        }

        [TestMethod]
        public void ActiveLastNameTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Stevens";
            //assign the data to the tutor
            aTutor.lastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.lastName, TestData);
        }

        [TestMethod]
        public void ActiveEmailTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "bobstevens@123.kdas.com";
            //assign the data to the tutor
            aTutor.email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.email, TestData);
        }

        [TestMethod]
        public void ActiveAvailabilityTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aTutor.availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.availability, TestData);
        }

        [TestMethod]
        public void ActiveSubjectTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Chemistry";
            //assign the data to the tutor
            aTutor.subject = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.subject, TestData);
        }


        [TestMethod]
        public void ActivePasswordTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "abc123";
            //assign the data to the tutor
            aTutor.password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.password, TestData);
        }

        [TestMethod]
        public void DateAddedTutorOK()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aTutor.dateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.dateAdded, TestData);
        }










    }
}
