using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Customer_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;


public partial class Public_Default : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            if(CustomerID != -1)
            {
                DisplayCustomer();
            }
        }

    }

    void DisplayCustomer()
    {
        clsCustomerCollection aCustomer = new clsCustomerCollection();

        aCustomer.ThisCustomer.Find(CustomerID);

        txtCustomerID.Text = aCustomer.ThisCustomer.CustomerID.ToString();
        txtFirstName.Text = aCustomer.ThisCustomer.CustomerName.getFirstName();
        txtLastName.Text = aCustomer.ThisCustomer.CustomerName.getLastName();
        txtDateOfBirth.Text = aCustomer.ThisCustomer.DateOfBirth.ToString();
        txtEmail.Text = aCustomer.ThisCustomer.Email;
        txtPhoneNumber.Text = aCustomer.ThisCustomer.PhoneNumber;
        txtPassword.Text = aCustomer.ThisCustomer.Password;
        txtCardNo.Text = aCustomer.ThisCustomer.CardNo;
        txtCardDate.Text = aCustomer.ThisCustomer.CardDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsCustomer aCustomer = new ClsCustomer();

        string firstName = txtFirstName.Text;

        string lastName = txtLastName.Text;

        string dateOfBirth = txtDateOfBirth.Text;

        string email = txtEmail.Text;

        string phoneNumber = txtPhoneNumber.Text;

        string password = txtPassword.Text;

        string cardNo = txtCardNo.Text;

        string cardDate = txtCardDate.Text;

        string Error = "";

        Error = aCustomer.Valid(firstName, lastName, dateOfBirth, email, phoneNumber, password, cardNo, cardDate);

        if (Error == "")
        {

            aCustomer.CustomerID = CustomerID;

            aCustomer.CustomerName = new Name(txtFirstName.Text, txtLastName.Text);

            aCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            aCustomer.Email = txtDateOfBirth.Text;

            aCustomer.PhoneNumber = txtPhoneNumber.Text;

            aCustomer.Password = txtPassword.Text;

            aCustomer.CardNo = txtCardNo.Text;

            aCustomer.CardDate = Convert.ToDateTime(txtCardDate.Text);

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = aCustomer;

                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);

                CustomerList.ThisCustomer = aCustomer;

                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
           lblError.Text = Error;
        }
    }

    public void btnFind_Click(object sender, EventArgs e)
    {
        ClsCustomer aCustomer = new ClsCustomer();

        Int32 cID;

        Boolean Found = false;

        cID = Convert.ToInt32(txtCustomerID.Text);

        Found = aCustomer.Find(cID);
        if (Found == true)
        {
            txtFirstName.Text = aCustomer.CustomerName.getFirstName();
            txtLastName.Text = aCustomer.CustomerName.getLastName();
            txtDateOfBirth.Text = aCustomer.DateOfBirth.ToString();
            txtEmail.Text = aCustomer.Email;
            txtPhoneNumber.Text = aCustomer.PhoneNumber;
            txtPassword.Text = aCustomer.Password;
            txtCardNo.Text = aCustomer.CardNo;
            txtCardDate.Text = aCustomer.CardDate.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}