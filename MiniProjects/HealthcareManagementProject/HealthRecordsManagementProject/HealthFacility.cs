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
        public List<VisitRecords>HealthFacilityVisits = new List<VisitRecords>();
        

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
            //for (int i = 0; i < HealthPractitioners.Count; i++)
           // {
              //  if (HealthPractitioners[i].lastName.Equals(search))
              ///  {
                   // Console.WriteLine("Found it!");
              //  }
                //else
                //{
                //    Console.WriteLine("Try again!");

                //}
                HealthPractitioner findthem = HealthPractitioners.Find(practitioners => practitioners.firstName == search);
                if(findthem != null)
                {
                    Console.WriteLine(findthem.getData());
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            //}
            return null;
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