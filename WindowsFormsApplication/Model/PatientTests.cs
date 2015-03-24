using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    class PatientTests
    {
        public int PatientTestsId { get; set; }
        public int VisitId { get; set; }
        public int TestId { get; set; }
        public DateTime TestOrdered{ get; set; }
        public DateTime TestTaken { get; set; }
        public DateTime TestCompleted { get; set; }
        public string Results { get; set; }
    }
}
