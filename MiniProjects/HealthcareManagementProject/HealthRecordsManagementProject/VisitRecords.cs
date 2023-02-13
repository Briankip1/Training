using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class VisitRecords
    {
        public string description;
        public Guid practitionerId;
        public string getRecordData()
        {
            return description + practitionerId;
        }
        public Guid patientId;
        public DateTime date;

       public VisitRecords(string description, Guid practitionerId, Patient patient)
        {
            this.description = description;
            this.practitionerId = practitionerId;
            patientId = patient.id;
            date = DateTime.Now;
        }

      
        public override string ToString()
        {
            return $"{description} {practitionerId} {patientId} {date}";
        }
    }
}
