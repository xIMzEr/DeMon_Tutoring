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
    }
}
