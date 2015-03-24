using System;
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
    }
}