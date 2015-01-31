using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayablesData.model;
using OpenIncidents.DAL;

namespace OpenIncidents.Controller
{


    public class IncidentControllers
    {

        public IncidentControllers()
        {
        }

        public List<Incidents> GetOpenIncidents()
        {
            return IncidentsDAL.GetOpenIncidents();
        }

        public List<Incidents> GetCustomers()
        {
            return IncidentsDAL.GetCustomers();
        }




    }
}
