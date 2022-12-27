﻿using System;
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
        public string uniquePatientID;
        public string homeAddress;

        public HealthCareProvider(string firstName, string lastName, string emailAddress, string cadre, string phoneNumber, string uniquePatientID, string homeAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.cadre = cadre;
            this.phoneNumber = phoneNumber;
            this.uniquePatientID = uniquePatientID;
            this.homeAddress = homeAddress;
        }  
        
        //public string AddRecords()
        //{
          
        //}

        //public string RetrieveRecords()
        //{
        // Can retrieve records upon authentication by Facility of Patient presence in the database
        // Can only read previous records without modification
        // Needs to enter unique ID to retrieve the record
        //}
    }
}
