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
        public string homeAddress; 
        //private string recordDescription;
        //    public string patientRecordDesription
        //{
        //    get {
        //        return recordDescription;
        //        }
        //}

        public Patient(string firstName, string lastName, string emailAddress, string phoneNumber, string uniquePatientID, string homeAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.uniquePatientID = uniquePatientID;
            this.homeAddress = homeAddress;
        }  
        
        //public string ViewRecord()
        //{
            //enter name
            // enter unique ID 
            // view personal health record

        //}

          //public void AuthorizeAccessToRecord()
        //{
            //Authorize to next of kin
            // Authorize to other interested parties
        //} 

           //public void EditBioData()
       // {
            // Allow editing of biodata only by the patient
        //}
       


    }
}
