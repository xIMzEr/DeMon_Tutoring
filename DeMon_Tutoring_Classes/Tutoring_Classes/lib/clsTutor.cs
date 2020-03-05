using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Classes.Tutoring_Classes.lib
{

       public class clsTutor
    {  //Fields

        //tutorId private member variable
        private Int32 mtutorId;
        //tutorId public property
        public Int32 tutorId
        { get
            {  return mtutorId; } set  { mtutorId = value; } }

        //tutorName private member variable
        private Name mtutorName;
        //tutorName public property
        public Name tutorName {
            get { return mtutorName; } set { mtutorName = value; } }

        //tutorEmail private member variable
        private string mtutorEmail;
        //tutorEmail public property
        public string tutorEmail {
            get { return mtutorEmail; } set { mtutorEmail = value; } }

        //tutorAvailable private member variable
        private bool mtutorAvailable;
        //tutorAvailable public property
        public bool tutorAvailabe {
            get { return mtutorAvailable; } set { mtutorAvailable = value; } }

        //tutorSubject private member variable
        private string mtutorSubject;
        //tutorSubject public property
        public string tutorSubject {
            get { return mtutorSubject; } set { mtutorSubject = value; } }

        //tutorPassword private member variable
        private string mtutorPassword;
        //tutorPassword public property
        public string tutorPassword {
            get { return mtutorPassword; } set { mtutorPassword = value; } }

        //dateAdded private member variable
        private DateTime mtutorDateAdded;
        //tutorDateAdded public property
        public DateTime tutorDateAdded {
            get { return mtutorDateAdded; } set { mtutorDateAdded = value; } }


        public bool active { get; set; }


        //Constructors
        public clsTutor(Int32 id, Name name, String email, String subject, String password, Boolean available, DateTime date)
        {
            tutorId = id;
            tutorName = name;
            tutorEmail = email;
            tutorAvailabe = available;
            tutorSubject = subject;
            tutorPassword = password;
            tutorDateAdded = date;
        }

        public clsTutor()
        {
            tutorId = 0;
            tutorName = null;
            tutorEmail = "";
            tutorAvailabe = true;
            tutorSubject = "";
            tutorPassword = "";
            tutorDateAdded = DateTime.Today;
        }

        //Methods

        public bool Find (Int32 tutorId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //adding paramater for the tutor id to search for
            DB.AddParameter("@tutorId", tutorId);
            //execute the stored procedure
            DB.Execute("sproc_tblTutor_FilterByTutorID");
            //if one record is found (there should be one or zero!)
            if(DB.Count ==  1)
            {
                //copy data from the database to the private data members in this class
                mtutorId = Convert.ToInt32(DB.DataTable.Rows[0]["TutorID"]);
                mtutorName = new Name(Convert.ToString(DB.DataTable.Rows[0]["TutorFirstName"]), Convert.ToString(DB.DataTable.Rows[0]["TutorLastName"]));
                mtutorEmail = Convert.ToString(DB.DataTable.Rows[0]["TutorEmail"]);
                mtutorAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["TutorAvailability"]);
                mtutorSubject = Convert.ToString(DB.DataTable.Rows[0]["TutorSubject"]);
                mtutorPassword = Convert.ToString(DB.DataTable.Rows[0]["TutorPassword"]);
                mtutorDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["TutorDateAdded"]);
                //return that everything worked
                return true;
            }
            //else if no record is found
            else
            {
                //return false indicating problem
                return false;
            }
            
        }


        //The public validation method
        public string Valid(string tutorFirstName, string tutorLastName, string tutorEmail, string tutorSubject, string tutorAvailable, string tutorDateAdded)
        //accepts 5 parameters for validation
        //the function returns a string containing any error messages
        //if no erros are found then a blank string is returned
        {
            
            //create a string variable to store the rror
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the tutorName field is blank
            if(tutorFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank: ";
            }
            if(tutorFirstName.Length > 15)
            {
                //record the error
                Error = Error + "The first name must be less than 15 characters: ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(tutorDateAdded);
            if(DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past";
            }
            //return any error messages
            return Error;
        }




        //To string method
        public string toString()
        {
            return "Tutor ID: " + this.tutorId + ", Tutor Name: " + this.tutorName +
                ", Tutor Email: " + this.tutorEmail +
                ", Tutor Subject: " + this.tutorSubject +
                ", Tutor Availability: " + this.tutorAvailabe +
                ", Tutor Date Added: " + this.tutorDateAdded;
        }

        
    }
}
