using System;
using System.Collections.Generic;
using WindowsFormsApplication.DBAccess;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.Controller
{
    public class NorthwindController
    {
        internal Employee LogIn(string name, string password)
        {
            return EmployeeDal.LogIn(name, password);
        }

        internal Employee ValidLogIn(String name, String password)
        {
            return EmployeeDal.ValidNurseLogIn(name, password);
        }

        internal List<Patient> GetAllPatients()
        {
            return PatientDal.GetAllPatients();
        }

        internal void AddPatients(Patient patient)
        {
            PatientDal.AddPatients(patient);
        }
    }
}