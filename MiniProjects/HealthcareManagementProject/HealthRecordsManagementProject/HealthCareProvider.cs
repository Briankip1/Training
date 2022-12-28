using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class HealthCareProvider
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string cadre;
        public string phoneNumber;
        public string uniqueID;
        public string homeAddress;

        public HealthCareProvider(string firstName, string lastName, string emailAddress, string cadre, string phoneNumber, string uniqueID, string homeAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.cadre = cadre;
            this.phoneNumber = phoneNumber;
            this.uniqueID = uniqueID;
            this.homeAddress = homeAddress;
        }

        public string CreatePatientRecord(Patient PatientRecords)
        {
            StringBuilder record = new StringBuilder();
            record.AppendLine("Patient Bio Data");
            Console.ReadLine();
            record.AppendLine("Medical History");
            Console.ReadLine();
            record.AppendLine("Impression");
            Console.ReadLine();
            record.AppendLine("Lab Findings");
            Console.ReadLine();
            record.AppendLine("Diagnosis");
            Console.ReadLine();
            record.AppendLine("Prescription");
            Console.ReadLine();
            PatientRecords.Add(record);

            return record.ToString();  
        }

        //public string RetrieveRecords()
        //{
        // Can retrieve records upon authentication by Facility of Patient presence in the database
        // Can only read previous records without modification
        // Needs to enter unique ID to retrieve the record
        //}
    }
}
