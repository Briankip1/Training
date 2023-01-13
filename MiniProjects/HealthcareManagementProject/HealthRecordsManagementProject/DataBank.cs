using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class DataBank
    {
        public string Name;
        public string uniqueID;
        public List<HealthFacility> facilityList;
        public List<HealthPractitioner> practitionerList;
        public List<Patient> patientList;
        public List<VisitRecords> visits;
     


        public DataBank(string name, string uniqueID) 
        {
            this.Name = name;
            this.uniqueID = uniqueID;
            facilityList = new List<HealthFacility>();
            practitionerList= new List<HealthPractitioner>();
            patientList = new List<Patient>();
            visits = new List<VisitRecords>();
        }



        //public List<HealthFacility> RetrieveMasterList()
        //{
            //Allows retrieval of patient and healthprovider records
        //}

          //public string AunthenticateAccess()
       // {
            //Authenticate records retrieval
            // UniqueIDs should match those in the system

       // }

        public void Store()
        {
            practitionerList.Add(HealthFacility.HealthPractitioners);
            visits.Add(HealthFacility.HealthFacilityVisits);
            patientList.Add(HealthFacility.Patients);
            //facilityList.Add(HealthFacility.parkNicollet);
            //store new list of patient and health provider records
        }
    }    

}
