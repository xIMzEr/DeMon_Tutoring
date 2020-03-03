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
        public int tutorId
        { get
            {
                //this line of code sends data out of the property
                return mtutorId;
            }
            set
            {
                //this line of code allows data into the property
                mtutorId = value;
            }
        }

        protected Name tutorName { get; set; }
        protected string tutorEmail { get; set; }
        protected bool tutorAvailabe { get; set; }
        protected string tutorSubject { get; set; }
        protected string tutorPassword { get; set; }
        protected DateTime tutorDateAdded { get; set; }
        private bool active { get; set; }


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
            tutorId = 0;
            tutorName = null;
            tutorEmail = "";
            tutorAvailabe = true;
            tutorSubject = "";
            tutorPassword = "";
            tutorDateAdded = DateTime.Today;
        }

        //Methods

        //find method
        public bool Find (int tutorId)
        {
            //set the private data members to the test data value
            mtutorId = 1;
            //always return true
            return true;
        }

        //get methods
        public int getId()
        {
            return this.tutorId;
        }
        public Name getName()
        {
            return this.tutorName;
        }

        public string getEmail()
        {
            return this.tutorEmail;
        }

        public bool getAvailability()
        {
            return this.tutorAvailabe;
        }

        public string getSubject()
        {
            return this.tutorSubject;
        }

        public string getPassword()
        {
            return this.tutorPassword;
        }

        public DateTime getDateAdded()
        {
            return this.tutorDateAdded;
        }

        //set methods
        public int setId(int id)
        {
            return this.tutorId = id;
        }

        public Name setName(Name name)
        {
            return this.tutorName = name;
        }

        public string setEmail(string email)
        {
            return this.tutorEmail = email;
        }

        public bool setAvailability(bool available)
        {
            return this.tutorAvailabe = available;
        }

        public string setSubject(string subject)
        {
            return this.tutorSubject = subject;
        }

        public string setPassword(string pass)
        {
            return this.tutorPassword = pass; ;
        }

        public DateTime setDateAdded(DateTime date)
        {
            return this.tutorDateAdded = date;
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
