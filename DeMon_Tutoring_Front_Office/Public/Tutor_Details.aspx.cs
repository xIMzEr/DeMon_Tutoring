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
        clsTutor Tutor = new clsTutor();
        //get the data from the session object
        Tutor = (clsTutor)Session["Tutor"];
        //display the tutor ID for this entry
        Response.Write(Tutor.getId());

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create instance of tutor
        clsTutor Tutor = new clsTutor();
        //capture the tutor name
        Tutor.setName(new Name(txtFirstName.Text, txtLastName.Text));
        //capture the email
        Tutor.setEmail(txtEmail.Text);


        //store the email in the session object
        Session["Tutor"] = Tutor;
        //redirect to the tutor viewer page
        Response.Redirect("TutorViewer.aspx");
    }
}