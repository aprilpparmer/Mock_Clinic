using System;
using WindowsFormsApplication.DBAccess;

namespace WindowsFormsApplication.Controller
{
    public class NorthwindController
    {
        internal String LogIn(string name, string password)
        {
            return NorthwindDal.LogIn(name, password);
        }

        internal Boolean ValidLogIn(String name, String password)
        {
            return NorthwindDal.ValidNurseLogIn(name, password);
        }
    }
}