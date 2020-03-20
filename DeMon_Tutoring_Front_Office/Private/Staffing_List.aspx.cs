using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;
public partial class Private_Staffing_List : System.Web.UI.Page
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
}