using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes
{
    public class clsCustomer
    {
        private bool Active { get; set; }
        private int CustomerID { get; set; }
        private bool Customer { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }
        private string Password { get; set; }
        private string CardNo { get; set; }
        private DateTime CardDate { get; set; }
        private bool StudentStatus { get; set; }

        public void clcCustomer(int cID, string fn, string ln, DateTime dob, string email, string number, string pword, string cardNo, DateTime cardDate, bool studentStat)
        {
            CustomerID = cID;
            FirstName = fn;
            LastName = ln;
            DateOfBirth = dob;
            Email = email;
            PhoneNumber = number;
            Password = pword;
            CardNo = cardNo;
            CardDate = cardDate;
            StudentStatus = studentStat;

        }

    }
}
