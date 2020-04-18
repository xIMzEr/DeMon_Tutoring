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
        //staff = (Staffing)Session["staff"];
        //Display the email for this staff
       
        //Response.Write(staff.getEmail());
       
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {

        //Create a new instance of staff
        Staffing staff = new Staffing();
        //String to store any error messages
        String Error = "";
        //Validate the data
        Error = staff.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtNumber.Text, txtDOB.Text);
        if(Error == "")
        {
            //Capture the Staff name
            staff.staffName = new Name(txtFirstName.Text, txtLastName.Text);
            //Capture the email
            staff.staffEmail = txtEmail.Text;
            //Capture the staff
            staff.staffNumber = txtNumber.Text;
            //Capture the staff DOB
            staff.staffDOB = Convert.ToDateTime(txtDOB.Text);
            //Capture the staff Validity
            staff.staffValid = StaffValid.Checked;
            //Create a new instance of the staffing collection
            StaffingCollection staffList = new StaffingCollection();
            //Set the thisStaff property
            staffList.ThisStaff = staff;
            //Adds the new record
            staffList.Add();
            //redirect to the aTutor page
            Response.Redirect("Staffing_List.aspx");
        }
        else
        {
            txtError.Visible = true;
            //display the error message
            txtError.Text = "Error! " + Error;
        }



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