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


    }
}
