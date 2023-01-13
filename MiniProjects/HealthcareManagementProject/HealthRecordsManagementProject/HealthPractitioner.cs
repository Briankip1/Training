using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Guid;

namespace HealthRecordsManagementProject

{
    public class HealthPractitioner
    {
        private Guid id;
        public Guid Id
        {
            get { return id; }
        }
        public string firstName;
        public string lastName;
        public string getData() 
        {
            return this.firstName + " " + this.lastName +" " + Id;
        }

        public HealthPractitioner(string firstName, string lastName, string emailAddress, string cadre, string phoneNumber, string homeAddress)
        {
            id = Guid.NewGuid();
            this.firstName = firstName;
            this.lastName = lastName;
           
        }

        public override string ToString()
        {
            return $" {firstName} {lastName} {id}";
        }

       
                
        //    }
        //// Can retrieve records upon authentication by Facility of Patient presence in the database
        //// Can only read previous records without modification
        //// Needs to enter unique ID to retrieve the record
        //}
    }
}
