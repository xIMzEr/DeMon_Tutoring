using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMon_Tutoring_Classes
{
    public class ObjStatus
    {

        private bool objectStatusTrue { get; set; }
        private bool objectStatusFalse { get; set; }

        public ObjStatus()
        {       
            objectStatusTrue = true;
            objectStatusFalse = false;
        }

        public ObjStatus(string statTrue, string statFalse)
        {
            if (statTrue == "1" )
            {
                objectStatusTrue = true;
            } else { objectStatusTrue = false; }

            if (statFalse == "0")
            {
                objectStatusFalse = false;
            } else { objectStatusFalse = true; }
            
        }
    } 
}
