﻿using System;
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

        public static int AddPatientVisitVitals(PatientVisitVitals vitals)
        {
            return PatientVisitVitalsDal.AddPatientVisitVitals(vitals);
        }

        internal List<Patient> GetPatientsByFirstNameAndLastName(String firstName, String lastName)
        {
            return PatientDal.getPatientsByFirstNameAndLastName(firstName, lastName);
        } 

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

        public static void UpdatePatientVisit(PatientVisit visit)
        {
            PatientVisitDal.UpdatePatientVisit(visit);
        }

        public static void UpdatePatientVisitVitals(PatientVisitVitals vitals)
        {
            PatientVisitVitalsDal.UpdatePatientVisitVitals(vitals);
        }
    }
}