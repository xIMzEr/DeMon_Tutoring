using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Testing.Class_Testing.Tutor_Tests
{
    [TestClass]
    public class TstTutor
    {
        //Good Test Data
        //creating some test data to pass to the validation method

        readonly string tutorFirstName = "Bob";
        readonly string tutorLastName = "Bobeth";
        readonly string tutorEmail = "email@email.com";
        readonly string tutorSubject = "Computing";
        readonly string tutorAvailable = "true";
        readonly string tutorDateAdded = DateTime.Now.Date.ToString();
        readonly string tutorPassword = "12345678910";

        //TESTING CLASS CREATION ----------------------------------------------------------------------------------------------
        [TestMethod]
        public void InstanceOk()
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //test to see that it now exists
            Assert.IsNotNull(aTutor);
        }

        //TESTING THE SETTING AND RETRIEVAL OF DATA ----------------------------------------------------------------------------------------------
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
            string TestData = "12345678910";
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


        //TESTING FIND METHOD ----------------------------------------------------------------------------------------------

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);
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
            if(aTutor.tutorId != 1)
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
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //check the property
            if (aTutor.tutorDateAdded != Convert.ToDateTime("13/03/2020"))
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

            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assumes that it is)
            Boolean Ok = true;
            //create some test data to assign to use with the method
            Int32 tutorId = 1;
            //invoke the method
            Found = aTutor.Find(tutorId);

            //get full name from class and compare with what should be the result
            if (aTutor.tutorName.getFullName() != "Bob Bob")
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
            if (aTutor.tutorEmail != "bobstevens@123.kdas.com")
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
            if (aTutor.tutorPassword != "12345678910")
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
            if (aTutor.tutorSubject != "Chemistry")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        //TESTING VALIDATION METHOD ----------------------------------------------------------------------------------------------
        [TestMethod]
        public void ValidationMethodOk()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }
        //TESTING VALIDATION FIRST NAME ----------------------------------------------------------------------------------------------
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorFirstName = "ab"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorFirstName = "";
            tutorFirstName = tutorFirstName.PadRight(14, 'a');

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorFirstName = ""; //this should pass
            tutorFirstName = tutorFirstName.PadRight(15, 'a');

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorFirstName = ""; //this should pass
            tutorFirstName = tutorFirstName.PadRight(8, 'a');

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        //TESTING VALIDATION LAST NAME----------------------------------------------------------------------------------------------

        [TestMethod]
        public void TutorLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorLastName = ""; //this should trigger an error

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorLastName = ""; //this should pass
            tutorLastName = tutorLastName.PadRight(14, 'a');

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorLastName = ""; //this should pass
            tutorLastName = tutorLastName.PadRight(15, 'a');

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorLastName = ""; //this should pass
            tutorLastName = tutorLastName.PadRight(8, 'a');

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            string tutorLastName = "";
            tutorLastName = tutorLastName.PadRight(500, 'a'); //this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        //TESTING VALIDATION DATEADDED ----------------------------------------------------------------------------------------------

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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
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
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        //TESTING VALIDATION EMAIL ----------------------------------------------------------------------------------------------

        [TestMethod]
        public void TutorEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = "aa"; //this should trigger an error

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorFirstName = "aaa";//this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = "abcd"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = ""; //this should pass
            tutorEmail = tutorEmail.PadRight(29, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = ""; //this should pass
            tutorEmail = tutorEmail.PadRight(30, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailMid()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = ""; //this should pass
            tutorEmail = tutorEmail.PadRight(14, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = "";
            tutorEmail = tutorEmail.PadRight(31, 'a');//this should fail


            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = "";
            tutorEmail = tutorEmail.PadRight(300, 'a'); //this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        //TESTING VALIDATION SUBJECT ----------------------------------------------------------------------------------------------
        [TestMethod]
        public void TutorSubjectMinLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = "aa"; //this should trigger an error

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = "aaa";//this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorEmail = "abcd"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = ""; //this should pass
            tutorSubject = tutorSubject.PadRight(14, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = ""; //this should pass
            tutorSubject = tutorSubject.PadRight(15, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectMid()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = ""; //this should pass
            tutorSubject = tutorSubject.PadRight(7, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = "";
            tutorSubject = tutorSubject.PadRight(16, 'a');//this should fail


            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorSubjectExtremeMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorSubject = "";
            tutorSubject = tutorSubject.PadRight(300, 'a'); //this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        //TESTING VALIDATION PASSWORD ----------------------------------------------------------------------------------------------
        [TestMethod]
        public void TutorPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = "1234567"; //this should trigger an error

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = "12345678";//this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = "123456789"; //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = ""; //this should pass
            tutorPassword = tutorPassword.PadRight(29, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = ""; //this should pass
            tutorPassword = tutorPassword.PadRight(30, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordMid()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = ""; //this should pass
            tutorPassword = tutorPassword.PadRight(15, 'a'); //this should pass

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
             Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = "";
            tutorPassword = tutorPassword.PadRight(31, 'a');//this should fail


            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = "";
            tutorPassword = tutorPassword.PadRight(300, 'a'); //this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void TutorPasswordExtremeMin()
        {
            //create an instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //string variable to store any error messages
            String Error = "";
            //creating some test data to pass the method
            string tutorPassword = ""; // this should fail

            //invoke the method
            Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }







    }
    }
