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
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayTutors();

            //populate the list and display the number of records found
           //lblError.Text = DisplayTutors() + " records in the database";

        }
    }

    void DisplayTutors()
    {
        //create an instance of the tutor collection
        DeMon_Tutoring_Classes.Tutoring_Classes.lib.clsTutorCollection Tutors = new DeMon_Tutoring_Classes.Tutoring_Classes.lib.clsTutorCollection();
        //set the data source to the list of counties in the collection
        lstTutorList.DataSource = Tutors.TutorList;
        //set the name of the primary key
        lstTutorList.DataValueField = "tutorId";
        //set the data field to display
        lstTutorList.DataTextField = "tutorEmail";

        //bind the data to the list
        lstTutorList.DataBind();

    }
    

    //event handler for the add butto
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["tutorId"] = -1;
        //redirect to the data entry page
        Response.Redirect("Tutor_Details.aspx");

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 tutorId;
        //if a record has been selected from the list
        if (lstTutorList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            tutorId = Convert.ToInt32(lstTutorList.SelectedValue);
            //store the data in the session object
            Session["tutorId"] = tutorId;
            //redirect to the delete page
            Response.Redirect("DeleteTutor.aspx");
        }
        else//if no selected record
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 tutorId;
        //if a record has been selected from the list
        if (lstTutorList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edited
            tutorId = Convert.ToInt32(lstTutorList.SelectedValue);
            //store the data in the session object
            Session["tutorId"] = tutorId;
            //redirect to the edit page
            Response.Redirect("Tutor_Details.aspx");

        }
        else//if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to edit from the list";
        }

    }
}