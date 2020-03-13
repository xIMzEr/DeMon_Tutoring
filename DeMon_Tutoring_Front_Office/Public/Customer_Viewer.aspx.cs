using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
using DeMon_Tutoring_Classes.Customer_Classes.lib;
public partial class Public_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new customer
        clsCustomer customer = new clsCustomer();

        //objStatus yes = new objStatus();


        //get data from session object
        customer = (clsCustomer)Session["customer"];

        Response.Write("<b> LOGIN SUCCESSFUL </b>");

        txtFirstName.Text = customer.CustomerName.getFirstName();
        txtLastName.Text = customer.CustomerName.getLastName();
        txtDateOfBirth.Text = customer.DateOfBirth;
        txtEmail.Text = customer.Email;
        txtPhoneNumber.Text = customer.PhoneNumber;
        txtPassword.Text = customer.Password;
        txtCardNo.Text = customer.CardNo;
        txtCardDate.Text = customer.CardDate;

        //rdbYes.Text = objStatusTrue.objectStatusTrue;


    }

}