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
    //variable to store the tutor ID
    Int32 tutorId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        tutorId = Convert.ToInt32(Session["tutorId"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(tutorId != -1)
            {
                //display the current data for the record
                DisplayTutor();
            }
            else
            {
                //set the date to todays date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/mm/yyyy");
            }
        }
    }

    void DisplayTutor()
    {
        //create an instance of the tutor list
        clsTutorCollection AllTutors = new clsTutorCollection();
        //find the record to update
        AllTutors.ThisTutor.Find(tutorId);

        //display the data for this record
        /*txtTutorId.Text = AllTutors.ThisTutor.tutorId.ToString();
        txtFirstName.Text = AllTutors.ThisTutor.tutorName.getFirstName();
        txtLastName.Text = AllTutors.ThisTutor.tutorName.getLastName();
        txtEmail.Text = AllTutors.ThisTutor.tutorEmail;
        txtPassword.Text = AllTutors.ThisTutor.tutorPassword;
        txtSubject.Text = AllTutors.ThisTutor.tutorSubject;
        txtAvailibility.Text = AllTutors.ThisTutor.tutorAvailabe.ToString();
        txtDateAdded.Text = AllTutors.ThisTutor.tutorDateAdded.ToString();
        */
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
            //capture the tutor ID
            aTutor.tutorId = tutorId;
            //capture the name
            aTutor.tutorName = new Name(tutorFirstName, tutorLastName);
            //capture the email
            aTutor.tutorEmail = tutorEmail;
            //capture the subject
            aTutor.tutorSubject = tutorSubject;
            //capture the date added
            aTutor.tutorDateAdded = Convert.ToDateTime(tutorDateAdded);
            //capture the password
            aTutor.tutorPassword = tutorPassword;

            //create a new instance of the tutor collection
            clsTutorCollection AllTutors = new clsTutorCollection();

            //if this is a new record i.e. tutorId = -1 then add the data
            if (tutorId == -1)
            {
                //set the ThisTutor property
                AllTutors.ThisTutor = aTutor;
                //add the new record
                AllTutors.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                AllTutors.ThisTutor.Find(tutorId);
                //set the ThisTutor property
                AllTutors.ThisTutor = aTutor;
                //update the record
                AllTutors.Update();
            }
         
            //redirect back to listpage
            Response.Redirect("TutorList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("TutorList.aspx");
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