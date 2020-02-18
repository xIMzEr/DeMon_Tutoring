using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeMon_Tutoring_Classes;
using DeMon_Tutoring_Classes.Tutoring_Classes.lib;

public partial class aTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //create a new instance of clsTutor
        clsTutor aTutor = new clsTutor();
        //get the data from the session object
        aTutor = (clsTutor)Session["aTutor"];
        //display the tutor ID for this entry
        Response.Write(aTutor.getId());
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            //create instance of tutor
            clsTutor aTutor = new clsTutor();
            //capture the tutor name
           // aTutor.setName(new Name(txtFirstName.Text, txtLastName.Text));
            // txtFirstName
            //capture the email
           // aTutor.setEmail(txtEmail.Text);


            //store the email in the session object
            Session["aTutor"] = aTutor;
            //redirect to the viewer page
            Response.Redirect("TutorViewer.aspx");

        }

    }

