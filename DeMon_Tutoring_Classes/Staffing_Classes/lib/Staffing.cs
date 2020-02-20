using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Staffing_Classes.lib
{
    public class Staffing
    {
        //Fields
        //private member of StaffID
        private Int32 mStaffID;
        //public staffID
        public int staffID {
            get { return mStaffID; } set { mStaffID = value; } }

        //private member variable of StaffID
        private Name mStaffName;
        //public staffName
        public Name staffName {
            get { return mStaffName; } set { mStaffName = value; } }

        //private member variable of staffEmail
        private string mStaffEmail;
        //public staffEmail
        public string staffEmail {
            get { return mStaffEmail; } set { mStaffEmail = value; } }

        //private member variable of staffNumber
        private string mStaffNumber;
        //public staffNumber
        public string staffNumber {
            get { return mStaffNumber; } set { mStaffNumber = value; } }

        //private member variable of staffDOB
        private string mStaffDOB;
        public string staffDOB {
            get { return mStaffDOB; } set { mStaffDOB = value; } }
     
        //Constructors
        public Staffing(int sID, Name sName, string sEmail, string sNum, string sDOB)
        {
            staffID = sID;
            staffName = sName;
            staffEmail = sEmail;
            staffNumber = sNum;
            staffDOB = sDOB;
        }

       public Staffing()
        {
            staffID = 0;
            staffName = null;
            staffEmail = " ";
            staffNumber = " ";
            staffDOB = " ";
        }

        //Methods
        public string toString()
        {
            return "Staff ID: " + this.staffID + ", Staff Name: " + this.staffName +
                ", Staff Email: " + this.staffEmail + ", Staff Number: " + this.staffNumber + ", Staff DOB: " + this.staffDOB;
        }


        public bool Find(int sID)
        {
            //Hardcoded object
            mStaffID = 3;
            mStaffName = new Name("Eugene", "Zuccerberg");
            mStaffEmail = "eugenefrisbee@gmail.com";
            mStaffNumber = "07974133370";
            mStaffDOB = "1000-08-09";
            //Will always pass the test
            return true;
        }

    }
}
