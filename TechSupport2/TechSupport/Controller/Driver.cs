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

        /// <summary>
        /// Updates an incident
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="techName"></param>
        /// <param name="IncidentID"></param>
        internal void UpdateIncident(String Description, String techName, int IncidentID)
        {
            IncidentsDAL.UpdateIncident(Description, techName, IncidentID);
        }

        /// <summary>
        /// Closes an incident
        /// </summary>
        /// <param name="IncidentID">the incident's id</param>
        internal void closeIncident(int IncidentID)
        {
            IncidentsDAL.closeIncident(IncidentID);
        }

        /// <summary>
        /// Gets a list of the customers
        /// </summary>
        /// <returns>the list of customers</returns>
        internal List<Incidents> GetCustomers()
        {
            return IncidentsDAL.GetCustomers();
        }

        /// <summary>
        /// Gets a list of products
        /// </summary>
        /// <returns>the products</returns>
        internal List<Incidents> GetProducts()
        {
            return IncidentsDAL.GetProducts();
        }
        /// <summary>
        /// Gets a list of technicians
        /// </summary>
        /// <returns>technicians</returns>
        internal List<Incidents> GetTechnicians()
        {
            return IncidentsDAL.GetTechnicians();
        }

        /// <summary>
        /// Checks if the incident is closed
        /// </summary>
        /// <param name="IncidentID"> the id to be checked</param>
        /// <returns>false if it isn't closed, true if it is</returns>
        internal Boolean GetCloseDate(int IncidentID)
        {
            return IncidentsDAL.GetCloseDate(IncidentID);
        }
    }
}
