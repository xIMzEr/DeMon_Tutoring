using System;
using DeMon_Tutoring_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeMon_Tutoring_Testing
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
            aTutor.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.Active, TestData);
        }

        [TestMethod]
        public void ActiveFirstNameTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Bob";
            //assign the data to the tutor
            aTutor.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.FirstName, TestData);
        }

        [TestMethod]
        public void ActiveLastNameTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Stevens";
            //assign the data to the tutor
            aTutor.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.LastName, TestData);
        }

        [TestMethod]
        public void ActiveEmailTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "bobstevens@123.kdas.com";
            //assign the data to the tutor
            aTutor.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.Email, TestData);
        }

        [TestMethod]
        public void ActiveAvailabilityTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aTutor.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.Availability, TestData);
        }

        [TestMethod]
        public void ActiveSubjectTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Chemistry";
            //assign the data to the tutor
            aTutor.Subject = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.Subject, TestData);
        }

        [TestMethod]
        public void ActiveTotalNumberOfSubjectsTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            int TestData = 1;
            //assign the data to the tutor
            aTutor.TotalNumberOfSubjects = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.TotalNumberOfSubjects, TestData);
        }

        [TestMethod]
        public void ActivePasswordTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "abc123";
            //assign the data to the tutor
            aTutor.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.Password, TestData);
        }









    }
}
