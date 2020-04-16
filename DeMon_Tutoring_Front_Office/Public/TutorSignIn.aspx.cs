using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_TutorSignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        //redirect to the delete page
        Response.Redirect("HomePage.aspx");
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("HomePage.aspx");
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
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
        if (Found == true) {
            if (aTutor.tutorId == tutorId && aTutor.tutorPassword == txtTutorPassword.Text)
            {
                    //store the data in the session object
                    Session["tutorId"] = tutorId;
                    //redirect to the edit page
                    Response.Redirect("TutorPersonalDetails.aspx");

                //hide the error label as we encountered no errors
                lblError.Visible = false;

            }
            else //record not found
            {
                string Error = "The tutor with the ID number " + tutorId + " was not found or your Password is incorrect";
                //display the error message
                lblError.Text = "[" + Error + "]";
                //set label to visible
                lblError.Visible = true;

            }
        }
    }
}