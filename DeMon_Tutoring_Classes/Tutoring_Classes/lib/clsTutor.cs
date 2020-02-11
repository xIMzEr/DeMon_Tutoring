using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes
{

    public class clsTutor
    {   
        //Fields
        private bool Active { get; set; }
        private DateTime DateAdded { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private bool Availability { get; set; }
        private string Subject { get; set; }
        private string Password { get; set; }


        //Constructors
        public void ClsTutor(String firstn, String lastn, String mail, String sub, String pass, Boolean available, DateTime date)
        {
            FirstName = firstn;
            LastName = lastn;
            Email = mail;
            Availability = available;
            Subject = sub;
            Password = pass;
            DateAdded = date;
        }

    }
}
