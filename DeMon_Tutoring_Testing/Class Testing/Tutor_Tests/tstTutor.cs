using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using DeMon_Tutoring_Classes.Tutoring_Classes;

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
        public void ActiveIdTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            int TestData = 1;
            //assign the data to the tutor
            aTutor.setId(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getId(), TestData);
        }

        [TestMethod]
        public void ActiveNameTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Name TestData = new Name("Bob, Bob");
            //assign the data to the tutor
            aTutor.setName(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getName(), TestData);
        }



        [TestMethod]
        public void ActiveEmailTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "bobstevens@123.kdas.com";
            //assign the data to the tutor
            aTutor.setEmail(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getEmail(), TestData);
        }

        [TestMethod]
        public void ActiveAvailabilityTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aTutor.setAvailability(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getAvailability(), TestData);
        }

        [TestMethod]
        public void ActiveSubjectTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Chemistry";
            //assign the data to the tutor
            aTutor.setSubject(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getSubject(), TestData);
        }


        [TestMethod]
        public void ActivePasswordTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "abc123";
            //assign the data to the tutor
            aTutor.setPassword(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getPassword(), TestData);
        }

        [TestMethod]
        public void DateAddedTutorOK()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aTutor.setDateAdded(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.getDateAdded(), TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            Int32 TestData = 1;
            //invoke the method
            Found = aTutor.Find(TestData);
            //test to see if the result is correct
            Assert.isTrue(Found);
        }











    }
}
