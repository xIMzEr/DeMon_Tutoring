using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes
{

    public class clsTutor
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Availability { get; set; }
        public string Subject { get; set; }
        public int TotalNumberOfSubjects { get; set; }
        public string Password { get; set; }
    }
}
