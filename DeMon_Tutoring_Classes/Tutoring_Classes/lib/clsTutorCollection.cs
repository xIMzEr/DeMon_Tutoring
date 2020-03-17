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

        //private data member thisTutor
        clsTutor mThisTutor = new clsTutor();
        //public property for ThisTutor
        public clsTutor ThisTutor { get { return mThisTutor; } set { mThisTutor = value; } }

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
                aTutor.tutorId = Convert.ToInt32(DB.DataTable.Rows[Index]["tutorId"]);
                aTutor.tutorName = new Name(Convert.ToString(DB.DataTable.Rows[Index]["firstName"]), Convert.ToString(DB.DataTable.Rows[0]["lastName"]));
                aTutor.tutorEmail = Convert.ToString(DB.DataTable.Rows[Index]["emailAddress"]);
                aTutor.tutorAvailabe = Convert.ToBoolean(DB.DataTable.Rows[Index]["availability"]);
                aTutor.tutorSubject = Convert.ToString(DB.DataTable.Rows[Index]["subject"]);
                aTutor.tutorPassword = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
                aTutor.tutorDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateAdded"]);
                //add the record to the private data member
                mTutorList.Add(aTutor);
                //point to the next record
                Index++;
            }
            
            
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisTutor
            //set the primary key value of the new record
            mThisTutor.tutorId = 123;
            //return the primary key of the new record
            return mThisTutor.tutorId;
        }
    }
}


