using System.Collections.Generic;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using System;

namespace DeMon_Tutoring_Classes.Tutoring_Classes.lib {
    public class clsTutorCollection
    {
        //private data member for the list
        List<clsTutor> mTutorList = new List<clsTutor>();
        //public property for tutorList
        public List<clsTutor> TutorList { get { return mTutorList; } set { mTutorList = value; } }
        //public property for count
        public int Count { get { return mTutorList.Count; } set { /*we shall worry about this later*/} }
       
        public clsTutor ThisTutor { get; set; }

        //constructor for the class
        public clsTutorCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblTutor_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank tutor
                clsTutor aTutor = new clsTutor();
                //read in fields from current record
                aTutor.tutorId = Convert.ToInt32(DB.DataTable.Rows[0]["tutorId"]);
                aTutor.tutorName = new Name(Convert.ToString(DB.DataTable.Rows[0]["firstName"]), Convert.ToString(DB.DataTable.Rows[0]["lastName"]));
                aTutor.tutorEmail = Convert.ToString(DB.DataTable.Rows[0]["emailAddress"]);
                aTutor.tutorAvailabe = Convert.ToBoolean(DB.DataTable.Rows[0]["availability"]);
                aTutor.tutorSubject = Convert.ToString(DB.DataTable.Rows[0]["subject"]);
                aTutor.tutorPassword = Convert.ToString(DB.DataTable.Rows[0]["password"]);
                aTutor.tutorDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["dateAdded"]);
                //add the record to the private data member
                mTutorList.Add(aTutor);
                //point to the next record
                Index++;
            }
            
            
        }
    }
}


