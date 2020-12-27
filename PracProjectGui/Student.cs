using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProjectGui
{
    public class Student
    {
        public string sId;
        public string sName;
        public string sEmail;
        public string sAddress;
        public string sAdmit;
        public string error;
        public string SId { get => sId; set => sId = value; }
        public string SName { get => sName; set => sName = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }
        public string SAddress { get => sAddress; set => sAddress = value; }
        public string SAdmit { get => sAdmit; set => sAdmit = value; }
        public string Error { get => error; set => error = value; }
    }
}
