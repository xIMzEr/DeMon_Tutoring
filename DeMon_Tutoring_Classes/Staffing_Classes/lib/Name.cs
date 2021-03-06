﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Staffing_Classes.lib
{
    public class Name
    {
        //Fields
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Name()
        {
            firstName = " ";
            lastName = " ";
        }

        public Name(string fN)
        {
            firstName = fN;
            lastName = " ";
        }

        public Name(string fN, string lN)
        {
            firstName = fN;
            lastName = lN;
        }


        //Methods

        //Returns a name object as a string
        public string getFullName()
        {
                return this.firstName + " " + this.lastName;
        }

        /*Name seperator seperates a string of a full name into a first name and last name and then assigns those
         * to a Name Object
         */
        public void nameSeperator(string fullName)
        {
            string[] name = fullName.Split(' ');
            this.firstName = name[0];
            this.lastName = name[1];
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setFirstName(String fn)
        {
            this.firstName = fn;
        }

        public void setLastName(String ln)
        {
            this.lastName = ln;
        }

    }
}
