using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;

public partial class Public_Tutor_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsTutor
        clsTutor tutor = new clsTutor();
        //get the data from the session object
        tutor = (clsTutor)Session["tutor"];
        //display the tutor ID for this entry
        Response.Write(tutor.getId());

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create instance of tutor
        clsTutor tutor = new clsTutor();
        //capture the tutor name
        tutor.setName(new Name(txtFirstName.Text, txtLastName.Text));
        //capture the email
        tutor.setEmail(txtEmail.Text);
        //Capture the date created
        tutor.setDateAdded(DateTime.Now);


        //store the email in the session object
        Session["tutor"] = tutor;
        //redirect to the tutor viewer page
        Response.Redirect("TutorViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtSubject.Text = "";
    }
}