using DeMon_Tutoring_Classes.Customer_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new customer

        ClsCustomer customer = new ClsCustomer();

        //get data from session object
        customer = (ClsCustomer)Session["customer"];


        Response.Write("<b> LOGIN SUCCESSFUL </b>");

        lblFirstName.Text = customer.CustomerName.getFirstName();
        lblLastName.Text = customer.CustomerName.getLastName();
        lblDateOfBirth.Text = customer.DateOfBirth.ToShortDateString();
        lblEmail.Text = customer.Email;
        lblPhoneNumber.Text = customer.PhoneNumber;
        lblPassword.Text = customer.Password;
        lblCardNo.Text = customer.CardNo;
        lblCardDate.Text = customer.CardDate.ToShortDateString();

    }
}