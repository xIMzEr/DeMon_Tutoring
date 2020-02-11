using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeMon_Tutoring_Testing.Database_Testing.Staffing_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class
            clsDataConnection data = new clsDataConnection();
            Assert.IsNotNull();
        }
    }
}
