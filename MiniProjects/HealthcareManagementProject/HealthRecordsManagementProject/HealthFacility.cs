using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class HealthFacility
    {
        public string Name;
        public string UniqueID;
        


        public HealthFacility(string name, string level, string uniqueID)
        {
            Name = name;
            UniqueID = uniqueID;
        }

        public VisitRecords CreateVisitRecord(HealthPractitioner practitioner, Patient patient)
        {
            VisitRecords newVisit = new VisitRecords("Description", practitioner, patient);
            return newVisit;
        }
    }
}
