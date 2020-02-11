using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes.Staffing_Classes.lib
{
    class Staffing
    {
        private int staffID { get; set; }
        private Name staffName { get; set;}
        private string staffEmail { get; set; }
        private string staffNumber { get; set; }
     

        public Staffing(int sID, Name sName, string sEmail, string sNum)
        {
            staffID = sID;
            staffName = sName;
            staffEmail = sEmail;
            staffNumber = sNum;
        }

        public string toString()
        {
            return "Staff ID: " + this.staffID + ", Staff Name: " + this.staffName +
                ", Staff Email: " + this.staffEmail + ", Staff Number: " + this.staffNumber;
        }

    }
}
