using System;
using System.Collections.Generic;
using System.Linq;

namespace DeMon_Tutoring_Classes.Staffing_Classes.lib
{
    public class StaffingCollection
    { 

        private List<Staffing> mStaffList = new List<Staffing>();
        public List<Staffing> StaffList { get { return mStaffList; }
            set { mStaffList = value; } }

        private Int32 mCount;
        public Int32 Count { get { return mStaffList.Count; }
            set { /*Worry about later */} }

        private Staffing mThisStaff;
        public Staffing ThisStaff {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            } 
        }


        //Constructor for the class
        public StaffingCollection()
        {
            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_TblStaffing_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //While there are record to process
            while(Index < RecordCount)
            {
                //Create a blank list of staff
                Staffing AStaff = new Staffing();
                //Read in the feilds from the curerent record
                AStaff.staffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.staffName = new Name(Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]), Convert.ToString(DB.DataTable.Rows[Index]["LastName"]));
                AStaff.staffNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffNumber"]);
                AStaff.staffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.staffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDob"]);
                AStaff.staffValid = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffValid"]);
                //Adds the record to the private data member list
                mStaffList.Add(AStaff);
                //Point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.staffName.getFirstName());
            DB.AddParameter("@LastName", mThisStaff.staffName.getLastName());
            DB.AddParameter("@StaffNumber", mThisStaff.staffNumber);
            DB.AddParameter("@StaffEmail", mThisStaff.staffEmail);
            DB.AddParameter("@StaffDob", mThisStaff.staffDOB);
            DB.AddParameter("@StaffValid", mThisStaff.staffValid);
            //execute the query returning the primary key value
            return DB.Execute("sproc_TblStaffing_Insert");
        }

        public void Delete()
        {
            //Deletes the staff record pointed to by thisStaff
            //Connection to the db
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@staffID", mThisStaff.staffID);
            //execute the stored procedure
            DB.Execute("sproc_TblStaffing_Delete");
        }
    }
}