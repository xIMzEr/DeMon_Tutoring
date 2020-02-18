using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
public partial class Public_Staffing_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of staff
        Staffing staff = new Staffing();
        //get the data from the session object
        staff = (Staffing)Session["staff"];
        //Display the email for this staff
       
        //Response.Write(staff.getEmail());
       
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {



        //Create a new instance of staff
        Staffing staff = new Staffing();
        //Capture the Staff name
        staff.setName(new Name(txtFirstName.Text, txtLastName.Text));
        //Capture the email
        staff.setEmail(txtEmail.Text);
        //Capture the staff
        staff.setNumber(txtNumber.Text);
        //Capture the staff DOB
        staff.setDOB(txtDOB.Text);
        //store the email in the session object
        Session["staff"] = staff;
        //redirect to the aTutor page
        Response.Redirect("staffingViewer.aspx");
    }

    public int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    protected void CancelButton_Click(object sender, EventArgs e)
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtNumber.Text = "";
        txtDOB.Text = "";
    }
}