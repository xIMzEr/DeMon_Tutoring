using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes;



    public partial class aTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //create a new instance of clsTutor
        clsTutor aTutor = new clsTutor();
        //get the data from the session object
        aTutor = (clsTutor)Session["aTutor"];
        //display the tutor ID for this entry
        Response.Write(aTutor.tutorId);
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            //create instance of the class we want to create
            clsTutor aTutor = new clsTutor();
            //capture the first name

        }

    }

