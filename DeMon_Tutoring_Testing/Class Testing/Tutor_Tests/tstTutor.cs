using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Tutor_Tests
{
    [TestClass]
    public class tstTutor
    {
        //good Test Data
        //creating some test data to pass to the validation method

        string tutorFirstName = "Bob";
        string tutorLastName = "Bobeth";
        string tutorEmail = "email@email.com";
        string tutorSubject = "Computing";
        string tutorAvailable = "True";
        string tutorDateAdded = DateTime.Now.Date.ToString();

        // testing of tutor class creation------------------
        [TestMethod]
        public void InstanceOk()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //test to see that it now exists
            Assert.IsNotNull(aTutor);
        }

        //testing the setting and retrieval of data ---------------------
        [TestMethod]
        public void TestIdTutor()
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
        public void TestNameTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Name TestData = new Name("Bob, Bob");
            //assign the data to the tutor
            aTutor.tutorName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorName, TestData);
        }



        [TestMethod]
        public void TestEmailTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "bobstevens@123.kdas.com";
            //assign the data to the tutor
            aTutor.tutorEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorEmail, TestData);
        }

        [TestMethod]
        public void TestAvailabilityTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            Boolean TestData = true;
            //assign the data to the tutor
            aTutor.tutorAvailabe = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorAvailabe, TestData);
        }

        [TestMethod]
        public void TestSubjectTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "Chemistry";
            //assign the data to the tutor
            aTutor.tutorSubject = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorSubject, TestData);
        }


        [TestMethod]
        public void TestPasswordTutor()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to tutor
            string TestData = "abc123";
            //assign the data to the tutor
            aTutor.tutorPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorPassword, TestData);
        }

        [TestMethod]
        public void TestDateAddedTutor()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aTutor.tutorDateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aTutor.tutorDateAdded, TestData);
        }


        //find method tests------------------------------

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
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTutorNotFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //check the tutor id number
            if(aTutor.tutorId !=1)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 3;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //check the property
            if (aTutor.tutorDateAdded != Convert.ToDateTime("04/03/2020"))
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestNameAddedFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //Name tutorName = new Name("Bob", "Bob");
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //get full name from class and compare with what should be the result
            if (aTutor.tutorName.getFullName()!= "Bob Bob")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestEmailAddedFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //get email from class and compare with expected result
            if (aTutor.tutorEmail != "bob@email.com")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestAvailableAddedFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //get availability from class and compare with expected result
            if (aTutor.tutorAvailabe != true)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestPasswordAddedFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //get password from class and compare with what the result should be
            if (aTutor.tutorPassword != "123")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestSubjectAddedFound()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //get subject from class and compare with expected result
            if (aTutor.tutorSubject != "Science")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidationMethodOk()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = ""; //this should trigger an error

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "a"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "aa"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "abcdefghijklmn"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "abcdefghijklmno"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameMid()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "abcdefgh"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "";
            tutorFirstName = tutorFirstName.PadRight(16, 'a');//this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "";
            tutorFirstName = tutorFirstName.PadRight(500, 'a'); //this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = ""; //this should trigger an error

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = "a"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = "aa"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = "abcdefghijklmn"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = "abcdefghijklmno"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameMid()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = "abcdefgh"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = "";
            tutorLastName = tutorLastName.PadRight(16, 'a');//this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorLastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "";
            tutorFirstName = tutorFirstName.PadRight(500, 'a'); //this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating test variable to store test date
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to less by 100 years
            TestDate = TestDate.AddYears(-100); // this should fail
            //have to convert date to string
            string tutorDateAdded = TestDate.ToString();

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating test variable to store test date
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to today -1 day
            TestDate = TestDate.AddDays(-1); // this should fail
            //have to convert date to string
            string tutorDateAdded = TestDate.ToString();

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating test variable to store test date
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;// this should pass
            //have to convert date to string
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating test variable to store test date
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date today's date plus 1 day
            TestDate = TestDate.AddDays(1); // this should fail
            //have to convert date to string
            string tutorDateAdded = TestDate.ToString();

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating test variable to store test date
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to today plus 100 years
            TestDate = TestDate.AddYears(100);
            //have to convert date to string
            string tutorDateAdded = TestDate.ToString();

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating test variable to store test date
            string tutorDateAdded = "this is not a valid date";

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorAvailable, tutorDateAdded);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }




    }
}
