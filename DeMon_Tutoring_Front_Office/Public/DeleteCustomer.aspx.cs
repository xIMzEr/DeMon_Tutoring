using DeMon_Tutoring_Classes.Customer_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerID;


    protected void Page_Load(object sender, EventArgs e)
    {

        CustomerID = Convert.ToInt32(Session["CustomerID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        
        AllCustomers.ThisCustomer.Find(CustomerID);
       
        AllCustomers.Delete();
       
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}