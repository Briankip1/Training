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
        
        public Guid Id
        {
            get { return Id; }
            //init { Id = value; }
        }
        public string firstName;
        public string lastName;
        public string getData() 
        {
            return this.firstName + " " + this.lastName +" " + Id;
        }

        public HealthPractitioner(string firstName, string lastName, string emailAddress, string cadre, string phoneNumber, string homeAddress)
        {
            Id = Guid.NewGuid();
            this.firstName = firstName;
            this.lastName = lastName;
           
        }

        public override string ToString()
        {
            return $" {firstName} {lastName} {Id}";
        }

    }
}
