using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    class PatientVisitVitals
    {
        public int VistalsId { get; set; }
        public int VisitId { get; set; }
        public string BloodPressure { get; set; }
        public string Temp { get; set; }
        public string Plulse { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
