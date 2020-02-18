using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes
{

    public class clsTutor
    {
        private bool Active { get; set; }
        private DateTime DateAdded { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private bool Availability { get; set; }
        private string Subject { get; set; }
        private string Password { get; set; }


        public void ClsTutor(String fn, String ln)
        {
            FirstName = fn;
            LastName = ln;
        }

    }
}
