using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class Patient
    {

        public string firstName;
        public string lastName;
        public string emailAddress;
        public string phoneNumber;
        public string uniquePatientID;
        public string getPatientData()
        {
            return firstName + " " + lastName + " " + phoneNumber;
        }

        public Patient(string firstName, string lastName, string emailAddress, string phoneNumber, string uniquePatientID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.uniquePatientID = uniquePatientID;
        }

        
    }


}
