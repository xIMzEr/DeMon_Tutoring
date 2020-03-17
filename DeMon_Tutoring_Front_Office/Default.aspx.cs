﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
            lstTutors.DataSource = Tutors.TutorList;
            //set the name of the primary key
            lstTutors.DataValueField = "tutorId";
            //set the data field to display
            lstTutors.DataTextField = "firstName";
            //bind the data to the list
            lstTutors.DataBind();
        
        }
    }
