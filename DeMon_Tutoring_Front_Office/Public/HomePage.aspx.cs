using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_FrontPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTutorSignUp_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["tutorId"] = -1;
        //redirect to the data entry page
        Response.Redirect("Tutor_Details.aspx");
    }

    protected void btnTutorSignIn_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page
        Response.Redirect("TutorSignIn.aspx");
    }

    protected void btnViewAllRecords_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page
        Response.Redirect("TutorList.aspx");
    }

    protected void btnStudentSignUp_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("Customer_Details.aspx");
    }

    protected void btnStudentRecords_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page
        Response.Redirect("CustomerList.aspx");
    }
}