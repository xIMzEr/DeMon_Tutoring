using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

public partial class Public_DeleteStaff : System.Web.UI.Page
{
    //Var to store the pk of the record to be deleted
    Int32 StaffID;

    //Event handler
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the address to be deleted from the sesion object
        StaffID = Convert.ToInt32(Session["staff"]);
    }

    protected void btnY_Click(object sender, EventArgs e)
    {
        StaffingCollection aStaffingCollection = new StaffingCollection();
        aStaffingCollection.ThisStaff.Find(StaffID);
        aStaffingCollection.Delete();
        Response.Redirect("Staffing_List.aspx");
    }
}