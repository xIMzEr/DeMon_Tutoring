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
        // THANKS TO SAM BECAUSE I DIDNT NEED THIS
        //create a new instance of clsTutor
       // clsTutor aTutor = new clsTutor();
        //get the data from the session object
        //0aTutor = (clsTutor)Session["aTutor"];
        //display the tutor ID for this entry
        //Response.Write(aTutor.tutorId);

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create instance of tutor
        clsTutor aTutor = new clsTutor();

        //capture the tutor first name
        string tutorFirstName = txtFirstName.Text;
        //capture the tutor last name
        string tutorLastName = txtLastName.Text;
        //capture the email
        string tutorEmail = txtEmail.Text;
        //capture the subject
        string tutorSubject = txtSubject.Text;
        //capture the date added
        string tutorDateAdded = txtDateAdded.Text;
        //capture the password
        string tutorPassword = txtPassword.Text;

       
        //variable to store error messages
        string Error = "";
        //validate the data
        Error = aTutor.Valid(tutorFirstName, tutorLastName, tutorEmail, tutorSubject, tutorDateAdded, tutorPassword);
        if (Error == "")
        {
            //capture the name
            aTutor.tutorName = new Name(tutorFirstName + tutorLastName);
            //capture the email
            aTutor.tutorEmail = tutorEmail;
            //capture the subject
            aTutor.tutorSubject = tutorSubject;
            //capture the date added
            aTutor.tutorDateAdded = Convert.ToDateTime(tutorDateAdded);
            //capture the password
            aTutor.tutorPassword = tutorPassword;

            //store the email in the session object
            Session["aTutor"] = aTutor;
            //redirect to the tutor viewer page
            Response.Write("TutorViewer.aspx"); // maybe response.redirect
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtSubject.Text = "";
        txtAvailibility.Text = "";
        txtDateAdded.Text = "";
        txtPassword.Text = "";
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
            txtPassword.Text = aTutor.tutorPassword;

        }

    }

}