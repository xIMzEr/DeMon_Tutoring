using System;
using System.Collections.Generic;
using System.Linq;

namespace DeMon_Tutoring_Classes.Staffing_Classes.lib
{
    public class StaffingCollection
    {
        //Fields
        private List<Staffing> mStaffList = new List<Staffing>();
        public List<Staffing> StaffList { get { return mStaffList; }
            set { mStaffList = value; } }

        private Int32 mCount;
        public Int32 Count { get { return mStaffList.Count; }
            set { /*Worry about later */} }

        public Staffing ThisStaff { get; set; }

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
                //Adds the record to the private data member list
                mStaffList.Add(AStaff);
                //Point at the next record
                Index++;
            }
        }

    }
}