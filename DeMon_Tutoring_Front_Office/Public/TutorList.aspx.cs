using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Public_TutorList : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayTutors();
        }
    }

    void DisplayTutors()
    {
        //create an instance of the county collection
        DeMon_Tutoring_Classes.Tutoring_Classes.lib.clsTutorCollection Tutors = new DeMon_Tutoring_Classes.Tutoring_Classes.lib.clsTutorCollection();
        //set the data source to the list of counties in the collection
        lstTutorList.DataSource = Tutors.TutorList;
        //set the name of the primary key
        lstTutorList.DataValueField = "tutorId";
        //set the data field to display
        lstTutorList.DataTextField = "tutorPassword";
        lstTutorList.DataTextField = "tutorEmail";

        //bind the data to the list
        lstTutorList.DataBind();

    }

    protected void lstTutorList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    //event handler for the add butto
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["tutorId"] = -1;
        //redirect to the data entry page
        Response.Redirect("Tutor_Details.aspx");

    }
}