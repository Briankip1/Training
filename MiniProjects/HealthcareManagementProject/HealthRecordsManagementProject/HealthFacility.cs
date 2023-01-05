using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class HealthFacility
    {
        public string Name;
        public string Level;
        public string UniqueID;
        public List<Patient> Patients = new List<Patient>();
        public List<HealthPractitioner> HealthPractitioners = new List<HealthPractitioner>();
        public List<VisitRecords> visits = new List<VisitRecords>();

        public HealthFacility(string name, string level, string uniqueID)
        {
            Name = name;
            Level = level;
            UniqueID = uniqueID;
        }

        public VisitRecords CreateVisitRecord(HealthPractitioner practitioner, Patient patient)
        {
            VisitRecords newVisit = new VisitRecords("Description", practitioner, patient, DateTime.Now);
            visits.Add(newVisit);
            return newVisit;
        }
            

    }


    

            //public string RetrievePatientRecords()
            //{
            //Can retrieve records registered within the facility
            //Can request access to patient records from other facilities
            //}

            // public string AuthenticateHealthProviders()
            // {
            //Authenticate health providers within facility before providing access to patient records
}