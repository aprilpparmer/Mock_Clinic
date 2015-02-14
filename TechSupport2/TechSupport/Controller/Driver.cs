using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayablesData.model;
using OpenIncidents.DAL;

namespace OpenIncidents.Controller
{


    public class IncidentController
    {


        public IncidentController()
        {

        }

        /// <summary>
        /// Gets the open incidents
        /// </summary>
        /// <returns>a list of open incidents</returns>
        public List<Incidents> GetOpenIncidents()
        {
            return IncidentsDAL.GetOpenIncidents();
        }

        /// <summary>
        /// Adds an incident to the database
        /// </summary>
        /// <param name="name">Customers name</param>
        /// <param name="product">Prodct Name</param>
        /// <param name="Title">Incident Title</param>
        /// <param name="Description">Incident description</param>
        internal void AddIncident(String name, String product, String Title, String Description)
        {
            IncidentsDAL.AddIncident(name, product, Title, Description);
        }

        /// <summary>
        /// Gets an incident from the database
        /// </summary>
        /// <param name="p">the incident id</param>
        /// <returns>the values from the incidents table</returns>
        internal List<Incidents> GetIncident(int p)
        {
           return IncidentsDAL.GetIncident(p);
        }

        internal void UpdateIncident(String Description, String techName, int IncidentID)
        {
            IncidentsDAL.UpdateIncident(Description, techName, IncidentID);
        }

        internal void closeIncident(int IncidentID)
        {
            IncidentsDAL.closeIncident(IncidentID);
        }
    }
}
