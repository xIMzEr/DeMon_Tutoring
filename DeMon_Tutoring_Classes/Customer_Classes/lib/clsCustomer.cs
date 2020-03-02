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
        //Customer Fields
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


        //Customer Constructors
        public void clscustomer(int cID, Name cName, DateTime cDob, string cEmail, string cNumber, string cPword, string cCardNo, DateTime cCardDate, Boolean cStudentStat)
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
            DateOfBirth = DateTime.Today;
            Email = "";
            PhoneNumber = "";
            Password = "";
            CardNo = "";
            CardDate = DateTime.Today;
            StudentStatus = true;
        }

        //Customer Set Methods
        public void setID(int ID)
        {
            this.CustomerID = ID;
        }

        public void setName(Name name)
        {
            this.CustomerName = name;
        }

        public void setDOB(DateTime dob)
        {
            this.DateOfBirth = dob;
        }
        
        public void setEmail(String email)
        {
            this.Email = email;
        }

        public void setPhoneNumber(String number)
        {
            this.PhoneNumber = number;
        }

        public void setPassword(String pword)
        {
            this.Password = pword;
        }

        public void setCardNo(String cardNo)
        {
            this.CardNo = cardNo;
        }

        public void setCardDate(DateTime cardDate)
        {
            this.CardDate = cardDate;
        }

        public void setStudentStatus(Boolean studentStat)
        {
            this.StudentStatus = studentStat;
        }
        
        //Customer Get Methods

        public int getID()
        {
            return this.CustomerID;
        }

        public Name getName()
        {
            return this.CustomerName;
        }

        public DateTime getDOB()
        {
            return this.DateOfBirth;
        }

        public String getEmail()
        {
            return this.Email;
        }

        public String getPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public String getPassword()
        {
            return this.Password;
        }

        public String getCardNo()
        {
            return this.CardNo;
        }

        public DateTime getCardDate()
        {
            return this.CardDate;
        }

        public Boolean getStudentStatus()
        {
            return this.StudentStatus;
        }

        //ToString Method

        public String toString()
        {
            return "CustomerID: " + this.CustomerID + ", CustomerName: " + this.CustomerName +
                ", DateOfBirth: " + this.DateOfBirth + ", Email: " + this.Email + ", PhoneNumber: " + this.PhoneNumber +
                ", Password: " + this.Password + ", CardNo: " + this.CardNo + ", CardDate: " + this.CardDate +
                ", StudentStatus: " + this.StudentStatus;
        }

    }
}


    

