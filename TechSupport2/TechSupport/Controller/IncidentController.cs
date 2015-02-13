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

        /// <summary>
        /// Gets an incident
        /// </summary>
        /// <param name="p">the incident id</param>
        /// <returns>a specified incident</returns>
        public List<Incidents> GetIncident(int p)
        {
            return IncidentsDAL.GetIncident(p);
        }


    }
}
