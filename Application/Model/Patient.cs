using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Child { get; set; }
        public int? MotherId { get; set; }
        public int? FatherId { get; set; }
    }
}
