﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeMon_Tutoring_Classes.Staffing_Classes.lib;

namespace DeMon_Tutoring_Classes.Tutoring_Classes.lib
{

       public class clsTutor
    {  //Fields

        //tutorId private member variable
        private Int32 mtutorId;
        //tutorId public property
        public int tutorId
        { get
            {  return mtutorId; } set  { mtutorId = value; } }

        //tutorName private member variable
        private Name mtutorName;
        //tutorName public property
        public Name tutorName {
            get { return mtutorName; } set { mtutorName = value; } }

        //tutorEmail private member variable
        private string mtutorEmail;
        //tutorEmail public property
        public string tutorEmail {
            get { return mtutorEmail; } set { mtutorEmail = value; } }

        //tutorAvailable private member variable
        private bool mtutorAvailable;
        //tutorAvailable public property
        public bool tutorAvailabe {
            get { return mtutorAvailable; } set { mtutorAvailable = value; } }

        //tutorSubject private member variable
        private string mtutorSubject;
        //tutorSubject public property
        public string tutorSubject {
            get { return mtutorSubject; } set { mtutorSubject = value; } }

        //tutorPassword private member variable
        private string mtutorPassword;
        //tutorPassword public property
        public string tutorPassword {
            get { return mtutorPassword; } set { mtutorPassword = value; } }

        //dateAdded private member variable
        private DateTime mtutorDateAdded;
        //tutorDateAdded public property
        public DateTime tutorDateAdded {
            get { return mtutorDateAdded; } set { mtutorDateAdded = value; } }


        public bool active { get; set; }


        //Constructors
        public clsTutor(int id, Name name, String email, String subject, String password, Boolean available, DateTime date)
        {
            tutorId = id;
            tutorName = name;
            tutorEmail = email;
            tutorAvailabe = available;
            tutorSubject = subject;
            tutorPassword = password;
            tutorDateAdded = date;
        }

        public clsTutor()
        {
            tutorId = 0;
            tutorName = null;
            tutorEmail = "";
            tutorAvailabe = true;
            tutorSubject = "";
            tutorPassword = "";
            tutorDateAdded = DateTime.Today;
        }

        //Methods

        //FIND method
        public bool Find (int tutorId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //adding paramater for the tutor id to search for
            DB.AddParameter("@tutorId", tutorId);
            //execute the stored procedure
            DB.Execute("sproc_tblTutor_FilterByTutorID");
            //if one record is found (there should be one or zero!)
            if(DB.Count ==  1)
            {
                //copy data from the database to the private data members in this class
                mtutorId = Convert.ToInt32(DB.DataTable.Rows[0]["TutorID"]);
                mtutorName = new Name(Convert.ToString(DB.DataTable.Rows[0]["TutorFirstName"]), Convert.ToString(DB.DataTable.Rows[0]["TutorLastName"]));
                mtutorEmail = Convert.ToString(DB.DataTable.Rows[0]["TutorEmail"]);
                mtutorAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["TutorAvailability"]);
                mtutorSubject = Convert.ToString(DB.DataTable.Rows[0]["TutorSubject"]);
                mtutorPassword = Convert.ToString(DB.DataTable.Rows[0]["TutorPassword"]);
                mtutorDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["TutorDateAdded"]);
                //return that everything worked
                return true;
            }
            //else if no record is found
            else
            {
                //return false indicating problem
                return false;
            }
            
        }


        //function for the public validation method
        public string Valid(string tutorName, string tutorEmail, string tutorSubject, string tutorAvailable, string tutorDateAdded)
        //accepts 5 parameters for validation
        //the function returns a string containing any error messages
        //if no erros are found then a blank string is returned
        {
            return "";
        }




        //To string method
        public string toString()
        {
            return "Tutor ID: " + this.tutorId + ", Tutor Name: " + this.tutorName +
                ", Tutor Email: " + this.tutorEmail +
                ", Tutor Subject: " + this.tutorSubject +
                ", Tutor Availability: " + this.tutorAvailabe +
                ", Tutor Date Added: " + this.tutorDateAdded;
        }

        
    }
}
