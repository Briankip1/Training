using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class HealthFacility
    {
        public string Name;
        public string UniqueID;
        public List<Patient> Patients = new List<Patient>();
        public List<HealthPractitioner> HealthPractitioners = new List<HealthPractitioner>();
        public List<VisitRecords> HealthFacilityVisits = new List<VisitRecords>();


        public HealthFacility(string name, string level, string uniqueID)
        {
            Name = name;
            UniqueID = uniqueID;
        }

        public VisitRecords CreateVisitRecord(HealthPractitioner practitioner, Patient patient)
        {
            VisitRecords newVisit = new VisitRecords("Description", practitioner, patient);
            HealthFacilityVisits.Add(newVisit);
            return newVisit;
        }

        public HealthPractitioner RetrievePractitioners()
        {
            Console.WriteLine("Which health practitioner do you want to find? (Search with First Name) ");
            string search = Console.ReadLine();

            HealthPractitioner findthem = HealthPractitioners.Find(practitioners => practitioners.firstName == search);
            if (findthem != null)
            {
                Console.WriteLine(findthem.getData());
            }
            else
            {
                Console.WriteLine("Not found");
            }

            return null;
        }

        public Patient RetrievePatient()
        {
            Console.WriteLine("Which patient do you want to find? (Search with First Name) ");
            string patientSearch = Console.ReadLine();

            Patient findPatient = Patients.Find(sickPatient => sickPatient.firstName == patientSearch);
            if (findPatient != null)
            {
                Console.WriteLine(findPatient.getPatientData());
            }
            else
            {
                Console.WriteLine("Not found");
            }

            return null;
        }

        public VisitRecords RetrieveHealthFacilityVisits()
        {
            Console.WriteLine("Which record do you want to find? (Search with First Name) ");
            string recordSearch = Console.ReadLine();

            VisitRecords findRecord = HealthFacilityVisits.Find(patientRecord => patientRecord.patient == recordSearch);
            if (findRecord != null)
            {
                Console.WriteLine(findRecord.getRecordData());
            }
            else
            {
                Console.WriteLine("Not found");
            }

            return null;
        }

    }
}


    

            //public string RetrievePatientRecords()
            //{
            //Can retrieve records registered within the facility
            //Can request access to patient records from other facilities
            //}

            // public string AuthenticateHealthProviders()
            // {
            //Authenticate health providers within facility before providing access to patient recor