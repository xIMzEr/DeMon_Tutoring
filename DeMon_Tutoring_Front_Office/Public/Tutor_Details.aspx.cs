using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

public partial class Public_Tutor_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsTutor
        clsTutor tutor = new clsTutor();

        //get the data from the session object
        tutor = (clsTutor)Session["tutor"];

        //display the tutor ID for this entry
        Response.Write(tutor.tutorId);

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create instance of tutor
        clsTutor tutor = new clsTutor();

        //capture the tutor name
        tutor.tutorName = new Name(txtFirstName.Text, txtLastName.Text);

        //capture the email
        tutor.tutorEmail = (txtEmail.Text);

        //Capture the date created
        tutor.tutorDateAdded = DateTime.Now;

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
        txtAvailibility.Text = "";
        txtDateAdded.Text = "";
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the tutor class
        clsTutor aTutor = new clsTutor();
        //variable to store the primary key
        Int32 tutorId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        tutorId = Convert.ToInt32(txtTutorId.Text);
        //find the record
        Found = aTutor.Find(tutorId);
        //if record is found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = aTutor.tutorName.getFirstName();
            txtLastName.Text = aTutor.tutorName.getLastName();
            txtEmail.Text = aTutor.tutorEmail;
            txtSubject.Text = aTutor.tutorSubject;
            txtAvailibility.Text = aTutor.tutorAvailabe.ToString();
            txtDateAdded.Text = aTutor.tutorDateAdded.ToString();

        }

    }
}