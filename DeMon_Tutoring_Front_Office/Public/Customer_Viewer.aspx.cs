using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Customer_Classes.lib;
public partial class Public_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new customer

        ClsCustomer customer = new ClsCustomer();
      
        //get data from session object
        customer = (ClsCustomer)Session["customer"];
        

        Response.Write("<b> LOGIN SUCCESSFUL </b>");

        txtFirstName.Text = customer.CustomerName.getFirstName();
        txtLastName.Text = customer.CustomerName.getLastName();
        txtDateOfBirth.Text = Convert.ToString(customer.DateOfBirth);
        txtEmail.Text = customer.Email;
        txtPhoneNumber.Text = customer.PhoneNumber;
        txtPassword.Text = customer.Password;
        txtCardNo.Text = customer.CardNo;
        txtCardDate.Text = Convert.ToString(customer.CardDate);

        rdbYes.Text = customer.StudentStatus;
        rdbNo.Text = customer.StudentStatus;

    }

}