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

        //get data from session object
        customer = (clsCustomer)Session["customer"];

        Response.Write("<b> LOGIN SUCCESSFUL </b>");

        lblFirstName.Text = customer.CustomerName.getFirstName();
        lblLastName.Text = customer.CustomerName.getLastName();
        lblDateOfBirth.text = customer.DateOfBirth;
        lblEmail.Text = customer.Email;
        lblPhoneNumber.Text = customer.PhoneNumber;
        lblPassword.Text = customer.Password;
        lblCardNo.Text = customer.CardNo;
        lblCardDate.Text = customer.CardDate;
        lblStudentStatus.Text = 


    }
}