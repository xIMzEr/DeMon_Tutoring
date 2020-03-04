using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Customer_Classes.lib
{
    public class clsCustomer
    {
        //Customer Fields
        public Boolean Active { get; set; }
        public int CustomerID { get; set; }
        public Boolean Customer { get; set; }
        public Name CustomerName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string CardNo { get; set; }
        public string CardDate { get; set; }
        public Boolean StudentStatus { get; set; }


        //Customer Constructors
        public void clscustomer(int cID, Name cName, string cDob, string cEmail, string cNumber, string cPword, string cCardNo, string cCardDate, Boolean cStudentStat)
        {
            CustomerID = cID;
            CustomerName = cName;
            DateOfBirth = cDob;
            Email = cEmail;
            PhoneNumber = cNumber;
            Password = cPword;
            CardNo = cCardNo;
            CardDate = cCardDate;
            StudentStatus = cStudentStat;

        }

        public clsCustomer()
        {
            CustomerID = 0;
            CustomerName = null;
            DateOfBirth = " ";
            Email = " ";
            PhoneNumber = " ";
            Password = " ";
            CardNo = " ";
            CardDate = " ";
            StudentStatus = true;
        }

        //ToString Method
        public string toString()
        {
            return "CustomerID: " + this.CustomerID + ", CustomerName: " + this.CustomerName +
                ", DateOfBirth: " + this.DateOfBirth + ", Email: " + this.Email + ", PhoneNumber: " + this.PhoneNumber +
                ", Password: " + this.Password + ", CardNo: " + this.CardNo + ", CardDate: " + this.CardDate +
                ", StudentStatus: " + this.StudentStatus;
        }

    }
}


    

