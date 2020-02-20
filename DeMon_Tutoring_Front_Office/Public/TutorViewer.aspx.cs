using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_TutorViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of tutor
        clsTutor tutor = new clsTutor();

        //Get the data from the session object
        tutor = (clsTutor)Session["tutor"];

        Response.Write("<b> LOGIN SUCCESSFUL </b>");

        //Display what text is in each field
        lblFirstName.Text = tutor.getName().getFirstName();
        lblLastName.Text = tutor.getName().getLastName();
        lblEmail.Text = tutor.getEmail();
        lblSubject.Text = tutor.getSubject();
    }
}