using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Order_Classes.lib;
public partial class Public_orderAdd : System.Web.UI.Page
{
    //Variable that stores the current staff record's ID
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id of the staff to be processed
        OrderID = Convert.ToInt32(Session["order"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (OrderID != -1)
            {
                //display the current data for the staff
                DisplayAddress();
            }
        }
    }

    void DisplayAddress()
    {
        OrderCollection oOrderCollection = new OrderCollection();
        orderCollection.ThisStaff.Find(OrderID);
        //display the data
        txtOrderNumber.Text = orderCollection.ThisOrder.OrderNumber.getOrderNumber();
        txtOrderDate.Text = orderCollection.ThisOrder.OrderDate.ToString();
        PaymentComplete.Checked = orderCollection.ThisOrder.PaymentComplete;
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {

        //Create a new instance of staff
        Order order = new Order();
        //String to store any error messages
        String Error = "";
        //Validate the data
        Error = Order.Valid(txtOrderNumber.Text, txtOrderDate.Text);
        if (Error == "")
        {
            //capture the order ID
            order.OrderID = OrderID;
            //Capture the order number
            order.OrderNumber = txtOrderNumber.Text
     
            order.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            //Capture the staff Validity
            order.OrderValid = OrderValid.Checked;
            //Create a new instance of the staffing collection
            OrderCollection OrderList = new OrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder = order;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = order;
                OrderList.Update();
            }
            //redirect to the aTutor page
            Response.Redirect("Tutor_List.aspx");
        }
        else
        {
           /** txtError.Visible = true;
            //display the error message
            txtError.Text = "Error! " + Error; **/
        }



    }


    protected void CancelButton_Click(object sender, EventArgs e)
    {
        txtOrderNumber.Text = "";
        txtOrderDate.Text = "";
        txtPaymentComplete.Text = "";

    }
}