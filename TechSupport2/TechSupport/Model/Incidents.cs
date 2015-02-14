﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayablesData.model
{
    public class Incidents
    {


        public Incidents()
        {
        }

 

        public string productCode { get; set; }

        public string description { get; set; }

        public DateTime openDate { get; set; }

        public DateTime closeDate { get; set; }

        public string customer { get; set; }

        public string technician { get; set; }

        public string title { get; set; }



    }
}
