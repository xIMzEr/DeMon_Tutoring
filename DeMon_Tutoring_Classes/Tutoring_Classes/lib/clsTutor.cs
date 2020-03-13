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
        {
            get{ return mtutorId; }
            set { mtutorId = value; }
        }

        //tutorName private member variable
        private Name mtutorName;
        //tutorName public property
        public Name tutorName
        {
            get { return mtutorName; }
            set { mtutorName = value; }
        }

        //tutorEmail private member variable
        private string mtutorEmail;
        //tutorEmail public property
        public string tutorEmail
        {
            get { return mtutorEmail; }
            set { mtutorEmail = value; }
        }

        //tutorAvailable private member variable
        private bool mtutorAvailable;
        //tutorAvailable public property
        public bool tutorAvailabe
        {
            get { return mtutorAvailable; }
            set { mtutorAvailable = value; }
        }

        //tutorSubject private member variable
        private string mtutorSubject;
        //tutorSubject public property
        public string tutorSubject
        {
            get { return mtutorSubject; }
            set { mtutorSubject = value; }
        }

        //tutorPassword private member variable
        private string mtutorPassword;
        //tutorPassword public property
        public string tutorPassword
        {
            get { return mtutorPassword; }
            set { mtutorPassword = value; }
        }

        //dateAdded private member variable
        private DateTime mtutorDateAdded;
        //tutorDateAdded public property
        public DateTime tutorDateAdded
        {
            get { return mtutorDateAdded; }
            set { mtutorDateAdded = value; }
        }

        //NOT USED
        //public bool active { get; set; }


        //Constructors
        public clsTutor(int id, Name name, String email, String subject, String password, Boolean available, DateTime date)
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
            tutorId = 1;
            tutorName = null;
            tutorEmail = "";
            tutorAvailabe = true;
            tutorSubject = "";
            tutorPassword = "";
            tutorDateAdded = DateTime.Now.Date;
        }

        //Methods

        public bool Find(int tutorId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //adding paramater for the tutor id to search for
            DB.AddParameter("@tutorId", tutorId);
            //execute the stored procedure
            DB.Execute("sproc_tblTutor_FilterByTutorID");

            //if one record is found (there should be one or zero!)
            if (DB.Count == 1)
            {
                //copy data from the database to the private data members in this class
                mtutorId = Convert.ToInt32(DB.DataTable.Rows[0]["tutorId"]);
                mtutorName = new Name(Convert.ToString(DB.DataTable.Rows[0]["firstName"]), Convert.ToString(DB.DataTable.Rows[0]["lastName"]));
                mtutorEmail = Convert.ToString(DB.DataTable.Rows[0]["emailAddress"]);
                mtutorAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["availability"]);
                mtutorSubject = Convert.ToString(DB.DataTable.Rows[0]["subject"]);
                mtutorPassword = Convert.ToString(DB.DataTable.Rows[0]["password"]);
                mtutorDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["dateAdded"]);
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
        public string Valid(string tutorFirstName, string tutorLastName, string tutorEmail, string tutorSubject, string tutorDateAdded, string tutorPassword)
        //accepts 5 parameters for validation
        //the function returns a string containing any error messages
        //if no erros are found then a blank string is returned
        {

            //create a string variable to store the rror
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //First Name tests---------------
            //checking to see if FirstName is empty
            if (tutorFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank: ";
            }
            //checking to see if FirstName exceeds 15 characters
            if (tutorFirstName.Length > 15)
            {
                //record the error
                Error = Error + "The first name must be less than 15 characters: ";
            }

            //First Name tests---------------
            //checking to see if LastName is empty
            if (tutorLastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank: ";
            }
            //checking to see if LastName exceeds 15 characters
            if (tutorLastName.Length > 15)
            {
                //record the error
                Error = Error + "The last name must be less than 15 characters: ";
            }

            //Email tests---------------
            //check to see if email is shorter than min
            if (tutorEmail.Length < 3)
            {
                //record the error
                Error = Error + "The email may not be less than 3 characters: ";
            }
            //check to see if email is longer than min
            if (tutorEmail.Length > 30)
            {
                //record the error
                Error = Error + "The email must be less than 30 characters: ";
            }


            //Subject tests---------------
            if (tutorSubject.Length < 3)
            {
                //record the error
                Error = Error + "The subject may not be less than 3 characters ";
            }
            if (tutorSubject.Length > 15)
            {
                //record the error
                Error = Error + "The subject must be less than 15 characters: ";
            }

            //Password tests---------------
            //check to see if password is shorter than min
            if (tutorPassword.Length < 8)
            {
                //record the error
                Error = Error + "The password may not be less than 8 characters: ";
            }
            //check to see if password is longer than min
            if (tutorPassword.Length > 30)
            {
                //record the error
                Error = Error + "The password must be less than 30 characters: ";
            }

            //tutorDateAdded tests ----------------
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(tutorDateAdded);
                //check to see if date is in the past
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if date is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
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
