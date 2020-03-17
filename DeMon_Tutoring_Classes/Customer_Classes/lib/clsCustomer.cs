using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Customer_Classes.lib
{
    public class ClsCustomer
    {
        //Customer Fields
      //  public Boolean Active { get; set; }
        //private Boolean active { get; set; }
        public int CustomerID
        { get { return mCustomerID; } set { mCustomerID = value; } }
        private Int32 mCustomerID { get; set; }
        public Boolean Customer { get { return mCustomer; } set { mCustomer = value; } }
        private Boolean mCustomer { get; set; }
        public Name CustomerName { get { return mCustomerName; } set { mCustomerName = value; } }
        private Name mCustomerName { get; set; }
        public string DateOfBirth { get { return mDateOfBirth; } set { mDateOfBirth = value; } }
        private string mDateOfBirth { get; set; }
        public string Email { get { return mEmail; } set { mEmail = value; } }
        private string mEmail { get; set; }
        public string PhoneNumber { get { return mPhoneNumber; } set { mPhoneNumber = value; } }
        private string mPhoneNumber { get; set; }
        public string Password { get { return mPassword; } set { mPassword = value; } }
        private string mPassword { get; set; }
        public string CardNo { get { return mCardNo; } set { mCardNo = value; } }
        private string mCardNo { get; set; }
        public string CardDate { get { return mCardDate; } set { mCardDate = value; } }
        private string mCardDate { get; set; }
        public string StudentStatus { get { return mStudentSatus; } set { mStudentSatus = value; } }
        private string mStudentSatus { get; set; }

        //Customer Constructors
        public ClsCustomer(int cID, Name cName, string cDob, string cEmail, string cNumber, string cPword, string cCardNo, string cCardDate, string cStudentStat)
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

        public ClsCustomer()
        {
            CustomerID = 0;
            CustomerName = null;
            DateOfBirth = " ";
            Email = " ";
            PhoneNumber = " ";
            Password = " ";
            CardNo = " ";
            CardDate = " ";
            StudentStatus = " ";
        }


        //ToString Method
        public string toString()
        {
            return "CustomerID: " + this.CustomerID + ", CustomerName: " + this.CustomerName +
                ", DateOfBirth: " + this.DateOfBirth + ", Email: " + this.Email + ", PhoneNumber: " + this.PhoneNumber +
                ", Password: " + this.Password + ", CardNo: " + this.CardNo + ", CardDate: " + this.CardDate +
                ", StudentStatus: " + this.StudentStatus;
        }

        public bool Find (Int32 CustomerID)
        {
            //creating an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //adding a parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //when a record is found, should be one or none
            if (DB.Count == 1)
            {

                mCustomerID = 728;
                mCustomerName = new Name(Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]));
                mDateOfBirth = Convert.ToString(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mCardNo = Convert.ToString(DB.DataTable.Rows[0]["CardNo"]);
                mCardDate = Convert.ToString(DB.DataTable.Rows[0]["CardDate"]);
                mStudentSatus = Convert.ToString(DB.DataTable.Rows[0]["StudentStatus"]);

                return true;

            }
            else
            {
                return false;
            }
        }

       
    }
}


    

