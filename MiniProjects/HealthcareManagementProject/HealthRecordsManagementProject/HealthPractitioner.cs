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
        private Guid practitionerGuid;
        public Guid Id
        {
            get{ return practitionerGuid; }
        }
        public string firstName;
        public string lastName;
        public string getData() 
        {
            return this.firstName + " " + this.lastName +" ";
        }

        public HealthPractitioner(string firstName, string lastName)
        {
            practitionerGuid = Guid.NewGuid();
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $" {firstName} {lastName} {Id}";
        }

    }
}
