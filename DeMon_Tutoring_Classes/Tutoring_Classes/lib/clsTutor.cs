using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Tutoring_Classes.lib
{

       public class clsTutor
    {   
        //Fields
        protected bool active { get; set; }
        protected int tutorId { get; set; }
        protected Name tutorName { get; set; }
        protected string tutorEmail { get; set; }
        protected bool tutorAvailabe { get; set; }
        protected string tutorSubject { get; set; }
        protected string tutorPassword { get; set; }
        protected DateTime tutorDateAdded { get; set; }


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
        
        //Methods

        //get methods
        public int getId()
        {
            return this.tutorId;
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
