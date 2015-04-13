using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    public class Diagnoses
    {
        public int DiagnosesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Treatment { get; set; }
        public Byte Enabled { get; set; }
        
    }
}
