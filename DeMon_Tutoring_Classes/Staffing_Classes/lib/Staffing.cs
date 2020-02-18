using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Staffing_Classes.lib
{
    public class Staffing
    {
        //Fields
        private int staffID { get; set; }
        private Name staffName { get; set;}
        private string staffEmail { get; set; }
        private string staffNumber { get; set; }
     
        //Constructors
        public Staffing(int sID, Name sName, string sEmail, string sNum)
        {
            staffID = sID;
            staffName = sName;
            staffEmail = sEmail;
            staffNumber = sNum;
        }

       public Staffing()
        {
            staffID = 0;
            staffName = null;
            staffEmail = " ";
            staffNumber = " ";
        }

        //Methods
        public string toString()
        {
            return "Staff ID: " + this.staffID + ", Staff Name: " + this.staffName +
                ", Staff Email: " + this.staffEmail + ", Staff Number: " + this.staffNumber;
        }

        public void setID(int ID)
        {
            this.staffID = ID;
        }

        public void setName(Name name)
        {
            this.staffName = name;
        }

        public void setEmail(string email)
        {
            this.staffEmail = email;
        }

        public void setNumber(string number)
        {
            this.staffNumber = number;
        }

        public int getID()
        {
            return this.staffID;
        }

        public Name getName()
        {
            return this.staffName;
        }

        public string getEmail()
        {
            return this.staffEmail;
        }

        public string getNumber()
        {
            return this.staffNumber;
        }


    }
}
