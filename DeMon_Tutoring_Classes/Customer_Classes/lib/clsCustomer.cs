using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Customer_Classes.lib
{
    class clsCustomer
    {
        private bool Active { get; set; }
        private int CustomerID { get; set; }
        private bool Customer { get; set; }
        private Name CustomerName { get; set; }
        private DateTime DateOfBirth { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }
        private string Password { get; set; }
        private string CardNo { get; set; }
        private DateTime CardDate { get; set; }
        private bool StudentStatus { get; set; }

        public void clscustomer(int cID, Name name, DateTime dob, string email, string number, string pword, string cardNo, DateTime cardDate, bool studentStat)
        {
            CustomerID = cID;
            CustomerName = name;
            DateOfBirth = dob;
            Email = email;
            PhoneNumber = number;
            Password = pword;
            CardNo = cardNo;
            CardDate = cardDate;
            StudentStatus = studentStat;

        }

        public clsCustomer()
        {
            CustomerID = 0;
            CustomerName = null;
            DateOfBirth = DateTime.Today;
            Email = "";
            PhoneNumber = "";
            Password = "";
            CardNo = "";
            CardDate = DateTime.Today;
            StudentStatus = true;
        }




    }
}
