using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    public class PatientVisitSymptoms
    {
        public int SymptomId { get; set; }
        public int VisitId { get; set; }
        public string SymptomName { get; set; }
        public int? DiagnosesID { get; set; }
    }
}
