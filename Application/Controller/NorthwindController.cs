using System;
using System.Collections.Generic;
using WindowsFormsApplication.DBAccess;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.Controller
{
    public class NorthwindController
    {

        internal Employee ValidNurseLogIn(String name, String password)
        {
            return EmployeeDal.EmployeeLogIn(name, password);
        }

        internal List<Patient> GetAllPatients()
        {
            return PatientDal.GetAllPatients();
        }

        internal void AddPatients(Patient patient)
        {
            PatientDal.AddPatients(patient);
        }

        public static int AddPatientVisit(PatientVisit patientVisit)
        {
           return PatientVisitDal.AddPatientVisit(patientVisit);
        }

        public static void AddPatientVisitVitals(PatientVisitVitals vitals)
        {
            PatientVisitVitalsDal.AddPatientVisitVitals(vitals);
        }

<<<<<<< HEAD:WindowsFormsApplication/Controller/NorthwindController.cs
        internal List<Patient> GetPatientsByNameAndDOB(String firstName, String lastName)
        {
            return PatientDal.getPatientsByNameAndDOB(firstName, lastName);
        } 
=======
        public static int AddPatientVisitSymptoms(PatientVisitSymptoms symptoms)
        {
            return PatientVisitSymptomsDal.AddPatientVisitSymptoms(symptoms);
        }

        public static void AddPatientVisitNotes(PatientVisitNotes note)
        {
            PatientVisitNotesDal.AddPatientVisitNotes(note);
        }

        public static void UpdatePatientDiagnoses(PatientVisitSymptoms symptoms)
        {
            PatientVisitSymptomsDal.UpdatePatientDiagnoses(symptoms);
        }
>>>>>>> abdb118843c343bca7a964edb95712cb3d2fe579:Application/Controller/NorthwindController.cs
    }
}