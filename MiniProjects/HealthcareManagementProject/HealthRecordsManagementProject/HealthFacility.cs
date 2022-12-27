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
        public List<Patient> PatientRecords;
        public List<HealthCareProvider> HealthCareProviders;

        public HealthFacility(string name, string level, string uniqueID, List<Patient> patientRecords, List<HealthCareProvider> healthCareProviders)
        {
            Name = name;
            Level = level;
            UniqueID = uniqueID;
            PatientRecords = patientRecords;
            HealthCareProviders = healthCareProviders;
        }

        //public string RetrievePatientRecords()
        //{
            //Can retrieve records registered within the facility
            //Can request access to patient records from other facilities
        //}

        // public string AuthenticateHealthProviders()
       // {
            //Authenticate health providers within facility before providing access to patient records

       // }

    }
}
