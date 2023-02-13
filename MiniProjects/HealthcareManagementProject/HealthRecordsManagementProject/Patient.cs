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
        public Guid id;
        public string getPatientData()
        {
            return firstName + " " + lastName + " " + id;
        }

        public Patient(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            id = Guid.NewGuid();

        }

        
    }


}
