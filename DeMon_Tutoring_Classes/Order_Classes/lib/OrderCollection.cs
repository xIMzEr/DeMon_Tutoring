using System;
using System.Collections.Generic;
using System.Linq;
using DeMon_Tutoring_Classes;

namespace DeMon_Tutoring_Classes.Order_Classes.lib
{
    public class OrderCollection
    {
        private List<Order> oOrderList = new List<Order>();
        public List<Order> OrderList
        {
            get { return oOrderList; }
            set { oOrderList = value; }
        }

        private Int32 oCount;
        public Int32 Count
        {
            get { return oOrderList.Count; }
            set { /*later*/}
        }

        private Order oThisOrder = new Order();
        public Order ThisOrder
        {
            get { return oThisOrder; }
            set { oThisOrder = value; }
        }

        //Constructor for the class
        public OrderCollection()
        {
            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_TblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the db based on the values input
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNumber", oThisOrder.OrderNumber);
            DB.AddParameter("@OrderDate", oThisOrder.OrderDate);
            DB.AddParameter("@PaymentComplete", oThisOrder.PaymentComplete);
          
            //execute the query returning the primary key value
            return DB.Execute("sproc_TblOrder_Insert");
        }

        public void Delete()
        {
            //Deletes the order record pointed to by thisORder
            //Connection to the db
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@OrderID", oThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_TblOrder_Delete");
        }

        public void Update()
        {
            {
                //adds a new record to the db based on the values input
                //connect to the db
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@OrderID", oThisOrder.OrderID);
             
                DB.AddParameter("@OrderNumber", oThisOrder.OrderNumber);
                DB.AddParameter("@OrderDate", oThisOrder.OrderDate);
                DB.AddParameter("@PaymentComplete", oThisOrder.PaymentComplete);
                

                //execute the query returning the primary key value
                 DB.Execute("sproc_TblOrder_Update");
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the arraylist based on the data table in the parameter DB
            //var storage for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the priv array list
            oOrderList = new List<Order>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                Order aOrder = new Order();
                //Read in the fields from the current record
                aOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
 
                aOrder.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
             
                aOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                aOrder.PaymentComplete = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentComplete"]);
                //add the staff to the private data member
                oOrderList.Add(aOrder);
                //point to the next record
                Index++;
            }
        }
    }
}