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
        public List<Patient> Patients = new List<Patient>();
        public List<VisitRecords> visits = new List<VisitRecords>();
     


        public DataBank(string name, string uniqueID) 
        {
            this.Name = name;
            this.uniqueID = uniqueID;

        }

        public void RetrievePractitioners()
        {
            Console.WriteLine("Which health practitioner do you want to find? (Search with First Name) ");
            string? search = Console.ReadLine();

            HealthPractitioner? findPractitioners = HealthPractitioners.Find(practitioners => practitioners.firstName == search);
            if (findPractitioners != null)
            {
                Console.WriteLine(findPractitioners.getData());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void RetrievePatient()
        {
            Console.WriteLine("Which patient do you want to find? (Search with First Name) ");
            string? patientSearch = Console.ReadLine();

            Patient? findPatient = Patients.Find(sickPatient => sickPatient.firstName == patientSearch);
            if (findPatient != null)
            {
                Console.WriteLine(findPatient.getPatientData());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void RetrieveHealthFacilityVisits()
        {
            Console.WriteLine("Which record do you want to find? (Search with First Name) ");
            string? recordSearch = Console.ReadLine();

            VisitRecords? findRecord = visits.Find(patientRecord => patientRecord.patient.uniquePatientID == recordSearch);
            if (findRecord != null)
            {
                Console.WriteLine(findRecord.getRecordData());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }    

}
