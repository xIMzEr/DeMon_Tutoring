using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_TutorPersonalDetails : System.Web.UI.Page
{
    //variable to store the tutor ID
    Int32 tutorId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        tutorId = Convert.ToInt32(Session["tutorId"]);

        //if this website hasn't been viewed before
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (tutorId != -1)
            {
                //display the current data for the record
                DisplayTutor();
                //set dateAdded box to today's date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            }
            else//this is a new record
            {
                //set the date to todays date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            }
        }


    }

    //this function displays the data for a tutor on the web form
    void DisplayTutor()
    {
        //create an instance of the tutor list
        clsTutorCollection MyTutors = new clsTutorCollection();
        //find the record to update
        MyTutors.ThisTutor.Find(tutorId);

        //display the data for this record
        txtTutorId.Text = MyTutors.ThisTutor.tutorId.ToString();
        //display first name
        txtFirstName.Text = MyTutors.ThisTutor.tutorFirstName;
        //display last name
        txtLastName.Text = MyTutors.ThisTutor.tutorLastName;
        //display email
        txtEmail.Text = MyTutors.ThisTutor.tutorEmail;
        //display password
        txtPassword.Text = MyTutors.ThisTutor.tutorPassword;
        //display subject
        txtSubject.Text = MyTutors.ThisTutor.tutorSubject;
        //display availability
        //availability checkbox
        chkAvailable.Checked = MyTutors.ThisTutor.tutorAvailabe;
        //display date added
        txtDateAdded.Text = MyTutors.ThisTutor.tutorDateAdded.ToString("dd/MM/yyyy");

    }


    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //create new instance of tutor collection
        clsTutorCollection AllTutors = new clsTutorCollection();
        //variable to store error messages
        string Error = "";
        //validate the data
        Error = AllTutors.ThisTutor.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtSubject.Text, txtDateAdded.Text, txtPassword.Text);
        //if there are no errors
        if (Error == "")
        {
                //find the record to be updated
                AllTutors.ThisTutor.Find(tutorId);
                //set all the properties
                AllTutors.ThisTutor.tutorFirstName = txtFirstName.Text;
                AllTutors.ThisTutor.tutorLastName = txtLastName.Text;
                AllTutors.ThisTutor.tutorEmail = txtEmail.Text;
                AllTutors.ThisTutor.tutorSubject = txtSubject.Text;
                AllTutors.ThisTutor.tutorDateAdded = Convert.ToDateTime(txtDateAdded.Text);
                AllTutors.ThisTutor.tutorPassword = txtPassword.Text;
                AllTutors.ThisTutor.tutorAvailabe = chkAvailable.Checked;
                //update the record with new data
                AllTutors.Update();

            //let user know that update was a success
            lblSuccess.Text = "[" + "Success Updating!" + "]";
            lblSuccess.Visible = true;
            lblError.Visible = false;
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = "[" + Error + "]";
            //set label to visible
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("TutorSignIn.aspx");
    }


    protected void btnHome_Click(object sender, EventArgs e)
    {
        //redirect to the delete page
        Response.Redirect("HomePage.aspx");

    }

    protected void btnDeleteRecord_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 tutorId;
        Int32 personal = 1;
        
            //get the primary key value of the record to delete
            tutorId = Convert.ToInt32(txtTutorId.Text);
            //store the data in the session object
            Session["tutorId"] = tutorId;
            //store that this is a personal deletion
            Session["deleteType"] = personal;
            //redirect to the delete page
            Response.Redirect("DeleteTutor.aspx");
        
      
    }
}