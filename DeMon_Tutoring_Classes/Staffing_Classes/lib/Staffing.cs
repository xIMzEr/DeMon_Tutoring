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
        private DateTime mStaffDOB;
        public DateTime staffDOB {
            get { return mStaffDOB; } set { mStaffDOB = value; } }
     
        //Constructors
        public Staffing(int sID, Name sName, string sEmail, string sNum, DateTime sDOB)
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
            staffDOB = DateTime.Now.Date;
        }

        //Methods
        public string toString()
        {
            return "Staff ID: " + this.staffID + ", Staff Name: " + this.staffName +
                ", Staff Email: " + this.staffEmail + ", Staff Number: " + this.staffNumber + ", Staff DOB: " + this.staffDOB;
        }


        public bool Find(int sID)
        {
            //Create a new instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the staffID to search for
            DB.AddParameter("staffID", sID);
            //Execute the stored procedure
            DB.Execute("sproc_TblStaffing_FilterByStaffID");
            //If one record is found (Only one or zero instances can exist)
            if(DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = new Name(Convert.ToString(DB.DataTable.Rows[0]["FirstName"]), Convert.ToString(DB.DataTable.Rows[0]["LastName"]));
                mStaffNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffNumber"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDob"]);
                //return that everything went ok
                return true;
            }
            //If no records are found
            else{
                //return false indicating a problem
                return false;
            }


            /**
                        //Hardcoded object
                        mStaffID = 3;
                        mStaffName = new Name("Eugene", "Zuccerberg");
                        mStaffEmail = "eugenefrisbee@gmail.com";
                        mStaffNumber = "07974133370";
                        mStaffDOB = "1000-08-09";
                        //Always return true
                        return true; **/
        }

        //function for public validation method
        public string Valid( string staffFN, string staffLN, string staffEmail, string staffNumber, string staffDOB)
            //this function accepts 5 parameters for validation
            //the function returns a string containing any error message
            //if no errors found then a blank string is returned 
        {
            //String to store the error
            String Error = "";
            //If the firstName is bank
            if(staffFN.Length == 0)
            {
                //Record the erorr
                Error = Error + "The First Name may not be blank : ";
            }
            //If the first name is greater than 15 characters
            if(staffFN.Length > 15)
            {
                //Record the error
                Error += "The first name must be less than 16 characters : ";
            }
            //Last name boundary limits
            if (staffLN.Length == 0)
            {
                //Record the erorr
                Error = Error + "The last Name may not be blank : ";
            }
            //If the last name is greater than 15 characters
            if (staffLN.Length > 15)
            {
                //Record the error
                Error += "The last name must be less than 16 characters : ";
            }
            //StaffNumber boundaries
            if (staffNumber.Length > 11)
            {
                //Record the error
                Error += "The staff number cannot be more than 11 characters : "; 
            }
            //StaffEmail boundaries
            if (staffEmail.Length < 3)
            {
                //Record the erorr
                Error = Error + "The staff email may not be smaller than 3 chars : ";
            }
            //If the last name is greater than 15 characters
            if (staffEmail.Length > 30)
            {
                //Record the error
                Error += "The email name must be less than 31 characters : ";
            }

            //Dob boundaries
            try
            {
                DateTime dOBTemp = Convert.ToDateTime(staffDOB);
                if (dOBTemp < DateTime.Now.Date.AddYears(-68))
                {
                    //Record the error
                    Error += "The dob cannot be less than the retirement age";
                }
                if (dOBTemp > DateTime.Now.Date.AddYears(-18))
                {
                    //Record the error
                    Error += "The dob cannot be more than 18 years old";
                }
            }
            catch
            {
                //Record the error
                Error += "The date was not a valid date";
            }
            return Error;
        }

    }
}
