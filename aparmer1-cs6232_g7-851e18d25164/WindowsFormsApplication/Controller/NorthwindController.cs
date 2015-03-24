using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication2.DBAccess;

namespace WindowsFormsApplication2.Controller
{
    public class NorthwindController
    {
        internal String LogIn(string name, string password)
        {
            return NorthwindDAL.LogIn(name, password);
        }

        internal Boolean validLogIn(String name, String password)
        {
            return NorthwindDAL.validNurseLogIn(name, password);
        }
    }
}