using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    class PatientVisitNotes
    {
        public int NotesId { get; set; }
        public int EmployeeId { get; set; }
        public int VisitId { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        
    }
}
