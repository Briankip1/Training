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
        public List<HealthFacility> facilityList = new List<HealthFacility>();
        public List<HealthPractitioner> HealthPractitioners = new List<HealthPractitioner>();

        public List<HealthPractitioner> practitionerList = new List<HealthPractitioner>();
        public List<Patient> Patients = new List<Patient>();
        public List<VisitRecords> visits = new List<VisitRecords>();
     


        public DataBank(string name, string uniqueID) 
        {
            this.Name = name;
            this.uniqueID = uniqueID;

        }

        //public HealthPractitioner RetrievePractitioners()
        //{
        //    Console.WriteLine("Which health practitioner do you want to find? (Search with First Name) ");
        //    string search = Console.ReadLine();

        //    HealthPractitioner findthem = HealthPractitioners.Find(practitioners => practitioners.firstName == search);
        //    if (findthem != null)
        //    {
        //        Console.WriteLine(findthem.getData());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not found");
        //    }

        //    return null;
        //}

        //public Patient RetrievePatient()
        //{
        //    Console.WriteLine("Which patient do you want to find? (Search with First Name) ");
        //    string patientSearch = Console.ReadLine();

        //    Patient findPatient = Patients.Find(sickPatient => sickPatient.firstName == patientSearch);
        //    if (findPatient != null)
        //    {
        //        Console.WriteLine(findPatient.getPatientData());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not found");
        //    }

        //    return null;

        //}



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
            ///practitionerList.Add(HealthFacility.HealthPractitioners);
            //visits.Add(HealthFacility.HealthFacilityVisits);
            //patientList.Add(HealthFacility.Patients);
            //facilityList.Add(HealthFacility.parkNicollet);
            //store new list of patient and health provider records
        }
    }    

}
