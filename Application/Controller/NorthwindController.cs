using System;
using System.Collections.Generic;
using WindowsFormsApplication.DBAccess;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.Controller
{
    public class NorthwindController
    {
        public static int DeletePatientAllergy(int patientID, string allergy_name)
        {
            return PatientAllergiesDal.DeletePatientAllergy(patientID, allergy_name);
        }

        public static int AddPatientAllergy(PatientAllergies allergies)
        {
            return PatientAllergiesDal.AddPatientAllergy(allergies);
        }

        internal Employee EmployeeLogIn(String name, String password)
        {
            return EmployeeDal.EmployeeLogIn(name, password);
        }

        public Boolean VerifyUniqueLogin(string login)
        {
            return EmployeeDal.VerifyUniqueLogin(login);
        }

        internal List<Diagnoses> GetAllDiagnoses()
        {
            return DiagnosesDal.GetAllDiagnoses();
        }

        internal List<Patient> GetAllPatients()
        {
            return PatientDal.GetAllPatients();
        }

        internal void AddPatients(Patient patient)
        {
            PatientDal.AddPatients(patient);
        }

        internal int UpdatePatients(Patient oldpatient, Patient newPatient)
        {
            return PatientDal.UpdatePatients(oldpatient, newPatient);
        }

        public static int AddPatientVisit(PatientVisit patientVisit)
        {
           return PatientVisitDal.AddPatientVisit(patientVisit);
        }

        public PatientTests GetPatientTest(int patientTestId)
        {
            return PatientTestsDal.getTest(patientTestId);
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeeDal.GetAllEmployees();
        }
        

        public int DeleteDiag(int diagId)
        {
            return DiagnosesDal.DeleteDiag(diagId);
        }

        public static int AddPatientVisitVitals(PatientVisitVitals vitals)
        {
            return PatientVisitVitalsDal.AddPatientVisitVitals(vitals);
        }

        internal List<Patient> GetPatientsByFirstNameAndLastName(String firstName, String lastName, String dob)
        {
            return PatientDal.searchPatients(firstName, lastName, dob);
        } 

        public static int AddPatientVisitSymptoms(PatientVisitSymptoms symptoms)
        {
            return PatientVisitSymptomsDal.AddPatientVisitSymptoms(symptoms);
        }

        public PatientVisitSymptoms GetAllPatientSymtomsByVisitId(int visitId)
        {
            return PatientVisitSymptomsDal.GetAllPatientSymtomsByVisitId(visitId);
        }

        public static int AddPatientVisitNotes(PatientVisitNotes note)
        {
            return PatientVisitNotesDal.AddPatientVisitNotes(note);
        }

        internal void AddDiagnoses(Diagnoses diag)
        {
            DiagnosesDal.AddDiagnoses(diag);
        }

        public Diagnoses GetDiagnoses(int? diagId)
        {
            return DiagnosesDal.GetDiagnoses(diagId);
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

        public static void UpdatePatientSymptoms(PatientVisitSymptoms symptoms)
        {
            PatientVisitSymptomsDal.UpdatePatientSymptoms(symptoms);
        }

        public static void UpdatePatientNotes(PatientVisitNotes note)
        {
            PatientVisitNotesDal.UpdatePatientNotes(note);
        }

        public Patient GetPatientsById(int patientId)
        {
             
             return PatientDal.GetPatientsById(patientId);
        }

       internal void AddEmployee(Employee employee)
        {
            EmployeeDal.AddEmployee(employee);
        }

       internal void UpdateEmployee(Employee employee)
       {
           EmployeeDal.UpdateEmployee(employee);
       }

       internal List<Employee> SearchEmployees(String LastName, String FirstName)
       {
          return EmployeeDal.searchEmployees(LastName, FirstName);
       }

       internal Employee GetEmployeeByID(int employeeID)
       {
           return EmployeeDal.GetEmployeeById(employeeID);
       }

       internal void DeleteEmployee(Employee deleteEmployee)
       {
           EmployeeDal.deleteEmployee(deleteEmployee);
       }

       internal void AddTest(Test test)
       {
           TestDal.AddTest(test);
       }

       internal List<Test> GetAllTests()
       {
           return TestDal.GetAllTests();
       }

       internal static Test GetTest(int testId)
       {
           return TestDal.GetTest(testId);
       }

       public int DeleteTest(int testId)
       {
           return TestDal.DeleteTest(testId);
       }

       public bool UpdateTest(int oldTestId, String newTestName)
       {
           return TestDal.updateTest(oldTestId, newTestName);
       }

       internal void OrderTest(PatientTests patientTest)
       {
           PatientTestsDal.OrderTest(patientTest);
       }

       public static bool UpdatePatientTest(PatientTests oldPatientTest, PatientTests newPatientTest)
       {
           return PatientTestsDal.UpdatePatientTest(oldPatientTest, newPatientTest);
       }

       internal bool UpdateDiagnoses(int visitID, int? diag, string symptom)
       {
           return PatientVisitSymptomsDal.UpdateDiagnoses(visitID, diag, symptom);
       }

       internal int DeletePatientTest(int patientTestID)
       {
           return PatientTestsDal.DeleteOrderedTest(patientTestID);
       }

       internal void AddAllergy(Allergy allergy)
       {
           AllergyDAL.AddAllergy(allergy);
       }

       internal List<Allergy> GetAllAllergies()
       {
           return AllergyDAL.GetAllAllergies();
       }

       public int DeleteAllergy(int allergyId)
       {
           return AllergyDAL.DeleteAllergy(allergyId);
       }
    }
}