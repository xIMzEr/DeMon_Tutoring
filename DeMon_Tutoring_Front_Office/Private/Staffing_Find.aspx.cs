using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
public partial class Private_Staffing_Find : System.Web.UI.Page
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an isntance of the staffing
        Staffing AStaff = new Staffing();
        //Variable to store the primary key
        Int32 StaffID;
        //Variable to indicate if found
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //If Found
        if(Found == true)
        {
            txtFirstName.Text = AStaff.staffName.getFirstName();
            txtLastName.Text = AStaff.staffName.getLastName();
            txtEmail.Text = AStaff.staffEmail;
            txtNumber.Text = AStaff.staffNumber;
            txtDOB.Text = AStaff.staffDOB;
        }
    }
}