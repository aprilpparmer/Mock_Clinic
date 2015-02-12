using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayablesData.model;
using OpenIncidents.DAL;

namespace OpenIncidents.Controller
{

/// <summary>
/// Incident controller
/// </summary>
    public class IncidentControllers
    {

        public IncidentControllers()
        {
        }
        /// <summary>
        /// Gets open incidents
        /// </summary>
        /// <returns></returns>
        public List<Incidents> GetOpenIncidents()
        {
            return IncidentsDAL.GetOpenIncidents();
        }

        public List<Incidents> GetIncident(int p)
        {
            return IncidentsDAL.GetIncident(p);
        }


    }
}
