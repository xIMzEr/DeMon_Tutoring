using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Tutoring_Classes.lib
{

     class clsTutor
    {   
        //Fields
        private bool active { get; set; }

        private int tutorId { get; set; }
        private Name tutorName { get; set; }
        private string tutorEmail { get; set; }
        private bool tutorAvailabe { get; set; }
        private string tutorSubject { get; set; }
        private string tutorPassword { get; set; }
        private DateTime tutorDateAdded { get; set; }


        //Constructors
        public void ClsTutor(int id, Name name, String email, String subj, String pass, Boolean available, DateTime date)
        {
            tutorId = id;
            tutorName = name;
            tutorEmail = email;
            tutorAvailabe = available;
            tutorSubject = subj;
            tutorPassword = pass;
            tutorDateAdded = date;
        }


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
