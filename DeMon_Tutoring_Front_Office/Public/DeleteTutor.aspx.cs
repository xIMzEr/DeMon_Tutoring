using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;

public partial class Public_DeleteTutor : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 tutorId;
    Int32 deleteType;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the tutor to be deleted from the session object
        tutorId = Convert.ToInt32(Session["tutorId"]);
        deleteType = Convert.ToInt32(Session["deleteType"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create new instance of the tutor list
        clsTutorCollection AllTutors = new clsTutorCollection();
        //find the record to delete
        AllTutors.ThisTutor.Find(tutorId);
        //delete this record
        AllTutors.Delete();
        //redirect back to the main page
        if (deleteType == 1)
        {
            Response.Redirect("TutorSignIn.aspx");
        }
        else
        {
            Response.Redirect("TutorList.aspx");
        }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        if (deleteType == 1)
        {
            Response.Redirect("TutorPersonalDetails.aspx");
        }
        else
        {
            Response.Redirect("TutorList.aspx");
        }
    }
}