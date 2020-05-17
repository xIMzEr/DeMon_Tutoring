using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
public partial class Public_Staffing_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displayed
        if(IsPostBack == false)
        {
                //Update the list box
                DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        //Create an instance of the Staff Collection
        StaffingCollection staffingCollection = new StaffingCollection();
        //Set the data source to the list of staff in the collection
        lstStaffingList.DataSource = staffingCollection.StaffList;
        //Set the name of te primary key
        lstStaffingList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffingList.DataTextField = "StaffEmail";
        //bind the data to the list
        lstStaffingList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this is a new record
        Session["staff"] = -1;
        //redirect to the data entry page
        Response.Redirect("Staffing_Details.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Store the primary key value of the record to be deleted
        Int32 staffID;
        //If a record has been selected from the list
        if (lstStaffingList.SelectedIndex != -1)
        {
            //get the PK of the record to delete
            staffID = Convert.ToInt32(lstStaffingList.SelectedValue);
            //store the data in the session object
            Session["staff"] = staffID;
            //redirect to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            //dispaly an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;

        if(lstStaffingList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffingList.SelectedValue);
            Session["staff"] = StaffID;
            Response.Redirect("Staffing_Details.aspx");
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        StaffingCollection Staff = new StaffingCollection();
        Staff.ReportByEmail(txtEmailFilter.Text);
        lstStaffingList.DataSource = Staff.StaffList;

        //Set the name of the primary key
        lstStaffingList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffingList.DataValueField = "StaffEmail";
        //bind the data to the list
        lstStaffingList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        StaffingCollection Staff = new StaffingCollection();
        Staff.ReportByEmail("");
        //clear any existing filter
        txtEmailFilter.Text = "";
        lstStaffingList.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaffingList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffingList.DataValueField = "StaffEmail";
        //bind the data to the list
        lstStaffingList.DataBind();
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staffing_Find.aspx");
    }
}