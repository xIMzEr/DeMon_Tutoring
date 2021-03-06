﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

public partial class Public_StaffingViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of staff
        Staffing staff = new Staffing();

        //Get the data from the session object
        staff = (Staffing)Session["staff"];

        Response.Write("<b> LOGIN SUCCESSFUL </b>");

        //Display what text is in each field
        lblFirstName.Text = staff.staffName.getFirstName();
        lblLastName.Text = staff.staffName.getLastName();
        lblEmail.Text = staff.staffEmail;
        lblNumber.Text = staff.staffNumber;
        lblDOB.Text = staff.staffDOB.ToString() ;
        lblValid.Text = staff.staffValid.ToString();
    }
}