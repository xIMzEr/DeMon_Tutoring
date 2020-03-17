using DeMon_Tutoring_Classes.Tutoring_Classes.lib;
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
            //populate the list and display the number of records found
            lblError.Text = DisplayTutors("") + " records in the database";

        }
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

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create instance of the address collection
        //lsTutorCollection Tutors = new clsTutorCollection();
        //Tutors.ReportBySubject(txtFilter.Text);
        //stTutorList.DataSource = Tutors.TutorList;

        //set name of primary key
        //lstTutorList.DataValueField = "tutorId";
        //set name of field to show
        //lstTutorList.DataTextField = "tutorSubject";
        //bind the data to the list
        // lstTutorList.DataBind();
        Int32 RecordCount;
        RecordCount = DisplayTutors(txtFilter.Text);
        lblError.Text = RecordCount + " records found";
    }
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayTutors("");
        lblError.Text = RecordCount + " records in the database";
        txtFilter.Text = "";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsTutorCollection Tutors = new clsTutorCollection();
        Tutors.ReportBySubject("");
        //clear existing filter
        txtFilter.Text = "";
        lstTutorList.DataSource = Tutors.TutorList;
        //set name of primary key
        lstTutorList.DataValueField = "tutorId";
        //set name of field to show
        lstTutorList.DataTextField = "tutorSubject";
        lstTutorList.DataBind();
    }

    Int32 DisplayTutors(string SubjectFilter)
    {
        //this function accepts one parameter, populates the list box with data from the middle layer class
        //returns a single value, the number of records found

        //create an instance of the tutor collection
        clsTutorCollection AllTutors = new clsTutorCollection();
        //var to store the count of records
        Int32 RecordCount;
        string firstName;
        string lastName;
        string email;
        string subject;
        string password;
        string tutorId;
        //var to store the index
        Int32 Index = 0;
        //clear the list of existing items
        lstTutorList.Items.Clear();
        //call the filter by subject method
        AllTutors.ReportBySubject(SubjectFilter);
        //get the count of records found
        RecordCount = AllTutors.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            firstName = Convert.ToString(AllTutors.TutorList[Index].tutorFirstName);
            lastName = Convert.ToString(AllTutors.TutorList[Index].tutorLastName);
            email = Convert.ToString(AllTutors.TutorList[Index].tutorEmail);
            subject = Convert.ToString(AllTutors.TutorList[Index].tutorSubject);
            password = Convert.ToString(AllTutors.TutorList[Index].tutorPassword);
            tutorId = Convert.ToString(AllTutors.TutorList[Index].tutorId);

            //set up a new object of class list item
            ListItem NewItem = new ListItem(firstName + " " + lastName + " " + email + " " + subject + " " + password, tutorId );
            //add new item to list
            lstTutorList.Items.Add(NewItem);
            Index++;

        }
        //return the number of records found
        return RecordCount;
    }

   
}