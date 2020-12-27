using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProjectGui
{
    public class Course_Assign
    {
        private string caId;
        private string cName;
        private string tName;
        private string year;
        private string sem;
        private string error;

        public string CaId { get => caId; set => caId = value; }
        public string CName { get => cName; set => cName = value; }
        public string TName { get => tName; set => tName = value; }
        public string Year { get => year; set => year = value; }
        public string Sem { get => sem; set => sem = value; }
        public string Error { get => error; set => error = value; }
    }
}
