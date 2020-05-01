using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Customer_Classes.lib;

public partial class Public_Customer_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }

    }

    void DisplayCustomers()
    {
        clsCustomerCollection customers  = new clsCustomerCollection();

        lstCustomerList.DataSource = customers.CustomerList;

        lstCustomerList.DataValueField = "CustomerID";

        lstCustomerList.DataTextField = "Email";

        lstCustomerList.DataBind();

    }

    protected void btnAdd_Click(object Sender, EventArgs e)
    {
        Session["CustomerID"] = -1;

        Response.Redirect("Customer_Details.aspx");
    }

    protected void btnDelete_Click(object Sender, EventArgs e)
    {
        Int32 CustomerID;

        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["CustomerID"] = CustomerID;

            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object Sender, EventArgs e)
    {
        Int32 CustomerID;

        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["CustomerID"] = CustomerID;

            Response.Redirect("Customer_Details.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }
}