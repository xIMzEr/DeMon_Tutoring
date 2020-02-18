using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

public partial class Public_Staffing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of staff
        Staffing staff = new Staffing();
        //get the data from the session object
        staff = (Staffing)Session["staff"];
        //Display the email for this staff
        Response.Write(staff.getEmail());
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {
        //Create a new instance of staff
        Staffing staff = new Staffing();
        //Capture the Staff name
        staff.setName(new Name(Request.Form["txtFirstName"], Request.Form["txtLastName"]));
        //Capture the email
        staff.setEmail(Request.Form["txtEmail"]);
        //Capture the staff
        staff.setNumber(Request.Form["txtNumber"]);
        //Capture the staff DOB
        staff.setDOB(Request.Form["txtDOB"]);
        //store the email in the session object
        Session["staff"] = staff;
        //redirect to the aTutor page
        Response.Redirect("staffingViewer.aspx");
    }
}