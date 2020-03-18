using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;

public partial class Public_TutorViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of tutor
        clsTutor aTutor = new clsTutor();
        //Get the data from the session object
        aTutor = (clsTutor)Session["aTutor"];
        //display the tutor ID for this entry
        //Response.Write("<b> LOGIN SUCCESSFUL </b>");
        Response.Write(aTutor.tutorId);

        //Display what text is in each field
        lblFirstName.Text = aTutor.tutorFirstName;
        lblLastName.Text = aTutor.tutorLastName;
        lblEmail.Text = aTutor.tutorEmail;
        lblSubject.Text = aTutor.tutorSubject;
        lblPassword.Text = aTutor.tutorPassword;
        lblDateAdded.Text = Convert.ToString(aTutor.tutorDateAdded);
        
    }
}