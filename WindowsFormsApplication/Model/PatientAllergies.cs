using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    class PatientAllergies
    {
        public int PatientAllergiesId { get; set; }
        public int AllergyId { get; set; }
        public int PatientId { get; set; }
    }
}
