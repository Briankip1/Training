using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class VisitRecords
    {
        public string description
        {

            set;
            get;
        }
        public HealthPractitioner practitioner;
        public string getRecordData()
        {
            return description + practitioner;
        }
        public Patient patient;
        public DateTime date;

       public VisitRecords(string Description, HealthPractitioner Practitioner, Patient Patient)
        {
            description = Description;
            practitioner = Practitioner;
            patient = Patient;
            date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{description} {practitioner} {patient} {date}";
        }
    }
}
