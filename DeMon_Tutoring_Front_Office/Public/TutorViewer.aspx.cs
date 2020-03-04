using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

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
        lblFirstName.Text = tutor.tutorName.getFirstName();
        lblLastName.Text = tutor.tutorName.getLastName();
        lblEmail.Text = tutor.tutorEmail;
        lblSubject.Text = tutor.tutorSubject;
    }
}