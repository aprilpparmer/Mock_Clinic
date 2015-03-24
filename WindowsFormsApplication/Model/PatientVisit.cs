using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    public class PatientVisit
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public DateTime VistDate { get; set; }
        public DateTime ApptDate { get; set; }
        public int DoctorId { get; set; }
        public int NurseId { get; set; }
    
    }
}
