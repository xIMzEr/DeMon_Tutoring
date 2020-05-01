using System.Collections.Generic;
using DeMon_Tutoring_Classes.Customer_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using System;

namespace DeMon_Tutoring_Classes.Customer_Classes.lib
{
    public class clsCustomerCollection
    {
        List<ClsCustomer> mCustomerList = new List<ClsCustomer>();
        //public property for CustomerList
        public List<ClsCustomer> CustomerList { get { return mCustomerList; } set { mCustomerList = value; } }

        public int Count { get { return mCustomerList.Count; } set { /* worry about later*/} }

        ClsCustomer mThisCustomer = new ClsCustomer();
        //public property for ThisTutor
        public ClsCustomer ThisCustomer { get { return mThisCustomer; } set { mThisCustomer = value; } }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();


            DB.AddParameter("@FirstName", mThisCustomer.CustomerName.getFirstName());
            DB.AddParameter("@LastName", mThisCustomer.CustomerName.getLastName());
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@CardNo", mThisCustomer.CardNo);
            DB.AddParameter("@CardDate", mThisCustomer.CardDate);

            return DB.Execute("sproc_tblCustomer_Insert");   
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);

            DB.Execute("sproc_tblCustomer_DeleteID");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.CustomerName.getFirstName());
            DB.AddParameter("@LastName", mThisCustomer.CustomerName.getLastName());
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@CardNo", mThisCustomer.CardNo);
            DB.AddParameter("@CardDate", mThisCustomer.CardDate);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByEmail(string Email)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Email", Email);

            DB.Execute("sproc_tblCustomer_FilterByEmail");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mCustomerList = new List<ClsCustomer>();

            while (Index < RecordCount)
            {
                ClsCustomer aCustomer = new ClsCustomer();

                aCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                aCustomer.CustomerName = new Name(Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]), Convert.ToString(DB.DataTable.Rows[Index]["LastName"]));
                aCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                aCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                aCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                aCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                aCustomer.CardNo = Convert.ToString(DB.DataTable.Rows[Index]["CardNo"]);
                aCustomer.CardDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CardDate"]);

                mCustomerList.Add(aCustomer);

                Index++;
            }
        }

    }
}
