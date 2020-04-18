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
    //Variable that stores the current staff record's ID
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id of the staff to be processed
        StaffID = Convert.ToInt32(Session["staff"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the staff
                DisplayAddress();
            }
        }
    }

    void DisplayAddress()
    {
        StaffingCollection staffingCollection = new StaffingCollection();
        staffingCollection.ThisStaff.Find(StaffID);
        //display the data
        txtFirstName.Text = staffingCollection.ThisStaff.staffName.getFirstName();
        txtLastName.Text = staffingCollection.ThisStaff.staffName.getLastName();
        txtEmail.Text = staffingCollection.ThisStaff.staffEmail;
        txtNumber.Text = staffingCollection.ThisStaff.staffNumber;
        txtDOB.Text = staffingCollection.ThisStaff.staffDOB.ToString();
        StaffValid.Checked = staffingCollection.ThisStaff.staffValid;
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
            //capture the staff ID
            staff.staffID = StaffID;
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

            if(StaffID == -1)
            {
                staffList.ThisStaff = staff;
                staffList.Add();
            }
            else
            {
                staffList.ThisStaff.Find(StaffID);
                staffList.ThisStaff = staff;
                staffList.Update();
            }
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