using System;
using System.Collections.Generic;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeMon_Tutoring_Testing.Class_Testing.Staffing_Tests
{
    [TestClass]
    public class TstStaffingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            StaffingCollection AllStaff = new StaffingCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffingListOK()
        {
            //Create an instance of StaffingCollection
            StaffingCollection AllStaff = new StaffingCollection();
            //Create some test data to assign to the object in this case the data needs to be a list of Staff
            List<Staffing> TestList = new List<Staffing>();
            //Add a staff to the list
            Staffing AStaff = new Staffing();
            //Set the staffs properties
            AStaff.staffName = new Name("Code", "Orange");
            AStaff.staffID = 11;
            AStaff.staffEmail = "CodeOrangeKids@gmail.com";
            AStaff.staffDOB = Convert.ToDateTime("08/09/1999");
            AStaff.staffNumber = "016189333";
            //Add the staff to the list
            TestList.Add(AStaff);
            //Assign the list to the StaffingCollection
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffOK()
        {
            //Create an instance of StaffingCollection
            StaffingCollection AllStaff = new StaffingCollection();
            //Create some test data to assign to the object
            Staffing AStaff = new Staffing();
            //Set the staffs properties
            AStaff.staffName = new Name("Code", "Orange");
            AStaff.staffID = 11;
            AStaff.staffEmail = "CodeOrangeKids@gmail.com";
            AStaff.staffDOB = Convert.ToDateTime("08/09/1999");
            AStaff.staffNumber = "016189333";
            //Assign the test data to the StaffingCollection property
            AllStaff.ThisStaff = AStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, AStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of StaffingCollection
            StaffingCollection AllStaff = new StaffingCollection();
            //Create some test data to assign to the object in this case the data needs to be a list of Staff
            List<Staffing> TestList = new List<Staffing>();
            //Add a staff to the list
            Staffing AStaff = new Staffing();
            //Set the staffs properties
            AStaff.staffName = new Name("Code", "Orange");
            AStaff.staffID = 11;
            AStaff.staffEmail = "CodeOrangeKids@gmail.com";
            AStaff.staffDOB = Convert.ToDateTime("08/09/1999");
            AStaff.staffNumber = "016189333";
            //Add the staff to the list
            TestList.Add(AStaff);
            //Assign the list to the StaffingCollection
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

    }
}
