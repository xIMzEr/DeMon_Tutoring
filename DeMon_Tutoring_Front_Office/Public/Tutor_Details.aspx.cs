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
            else//this is a new record
            {
                //set the date to todays date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/mm/yyyy");
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
        txtAvailibility.Text = MyTutors.ThisTutor.tutorAvailabe.ToString();
        //display date added
        txtDateAdded.Text = MyTutors.ThisTutor.tutorDateAdded.ToString("dd/mm/yyyy");
        
    }


    protected void btnRegister_Click(object sender, EventArgs e)
    {
        /*//create instance of tutor
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
        */
        clsTutorCollection AllTutors = new clsTutorCollection();
        //variable to store error messages
        string Error = "";
        //validate the data
        Error = AllTutors.ThisTutor.Valid(txtFirstName.Text, txtLastName.Text ,txtEmail.Text, txtSubject.Text, txtDateAdded.Text, txtPassword.Text);
        if (Error == "")
        {
            //if this is a new record i.e. tutorId = -1 then add the data
            if (tutorId == -1)
            {
                //set all properties
                AllTutors.ThisTutor.tutorFirstName = txtFirstName.Text;
                AllTutors.ThisTutor.tutorLastName = txtLastName.Text;
                AllTutors.ThisTutor.tutorEmail = txtEmail.Text;
                AllTutors.ThisTutor.tutorSubject = txtSubject.Text;
                AllTutors.ThisTutor.tutorDateAdded = Convert.ToDateTime(txtDateAdded.Text);
                AllTutors.ThisTutor.tutorPassword = txtPassword.Text;
                AllTutors.ThisTutor.tutorAvailabe = Convert.ToBoolean(txtAvailibility.Text);
                //invoke the add method
                AllTutors.Add();
            }
            //otherwise it must be an update
            else
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
                AllTutors.ThisTutor.tutorAvailabe = Convert.ToBoolean(txtAvailibility.Text);
                //update the record with new data
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
            txtFirstName.Text = aTutor.tutorFirstName;
            txtLastName.Text = aTutor.tutorLastName;
            txtEmail.Text = aTutor.tutorEmail;
            txtSubject.Text = aTutor.tutorSubject;
            txtAvailibility.Text = aTutor.tutorAvailabe.ToString();
            txtDateAdded.Text = aTutor.tutorDateAdded.ToString();
            txtPassword.Text = aTutor.tutorPassword;

        }

    }



    
}