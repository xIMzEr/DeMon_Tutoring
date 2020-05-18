using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeMon_Tutoring_Classes.Order_Classes.lib
{
    public class Order
    {
        //fields
        //private member of orderID
        private Int32 mOrderID;
        //public order ID
        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        //priv member of order number
        private int mOrderNumber;
        //public order number
        public int OrderNumber
        {
            get { return mOrderNumber; }
            set { mOrderNumber = value; }
        }
        //private member of order date
        private DateTime mOrderDate;
        //public order date
        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }
        //private member of payment complete status
        private Boolean mPaymentComplete;
        //public member of the same 
        public Boolean PaymentComplete
        {
            get { return mPaymentComplete; }
            set { mPaymentComplete = value;}
        }
        // constructors
         public Order (int oID, int oOrderNum, DateTime oOrderDate, Boolean oPaymentComplete)
        {
            OrderID = oID;
            OrderNumber = oOrderNumber;
            OrderDate = oOrderDate;
            PaymentComplete = oPaymentComplete;
        }

    
        public Order()
        {
            OrderID = 0;
            OrderNumber = 0;
            OrderDate = DateTime.Now.Date;
            PaymentComplete = false;
        }

        //methods
        public string toString()
        {
            return "OrderID: " + this.OrderID + ", OrderNumber: " + this.OrderNumber + ", Order Date:" + this.OrderDate
                + ", Payment complete: " + this.PaymentComplete;
        }

        public bool find(int oID)
        {
            //create a new instance of a data connection
            clsDataConnection DB = new clsDataConnection();

            //add the orderID as a parameter to search for
            DB.AddParameter("OrderID", oID);

            //execute the stored procedure for find
            DB.execute("sproc_TblOrder_FindOrderID");

            //if a record is found then
            if (DB.count == 1)
            {//Copy the data from the database to the private data members
                oOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                oOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                oOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                oPaymentComplete = Convert.ToBoolean(DB.DataTable.Rows[0]["Payment Complete:"]);
                //return that everything went ok
                return true;
            }
            //if no records are found then
            else
            {
                //return false
                return false;
            }
        }

        public string Validation(string ordNum, DateTime ordDate)
        {
            //string to store the error
            string Error = "";

            if (ordNum.length == 0)
            {
                //record the error
                Error = Error + "The order number cannot be blank: ";
            }


            //order date boundaries

            try
            {
                if (ordDate < DateTime.Now.Date)
                {
                    Error += "The Order date is set for a date before todays date";

                }
            }
            catch
            {
                Error += "The date is not valid";
            }
        }
       
    }
}