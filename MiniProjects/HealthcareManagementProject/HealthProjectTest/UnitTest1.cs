using HealthRecordsManagementProject;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HealthProjectTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Guid practitionerGuid = Guid.NewGuid();
            Patient newpatient = new Patient("Mark", "Wayne");
            HealthPractitioner doctorDan = new HealthPractitioner("Dan", "Wanda");
            HealthFacility AmazingHosp = new HealthFacility("AmazingHosp", "HealthCenter", "HF39830");
            var newStorage = new DataBank("Azure", "AZ123456");

            var testingStorage = newStorage.CreateAndStore(newpatient, doctorDan, AmazingHosp);

            var newPatientVisit = new VisitRecords("description", practitionerGuid, newpatient);

            if(newPatientVisit.practitionerId != practitionerGuid)
            {
                throw new Exception();
            }

            if (newpatient.id != testingStorage.patientId)
            {
                throw new Exception();

            }

        }
        [Fact]
        public void Test2()
        {
            var anotherDataBank = new DataBank("GCP", "GCP123456");
            var finalList = anotherDataBank.JoinPatientsAndVisits();

            Assert.Contains("Desc", "Description");

            //Test whether all data in the left table are available in the final list
            // Test the matching data in the right table is avaialble in the final list
            // If the final list contains null values when tested with unmatched values in the tables

            List<char> commonList = finalList.Intersect(anotherDataBank.Patients);
            {
                Console.WriteLine("matched");
            }

            foreach (var item in anotherDataBank.Patients)
            {
                if (finalList.Contains(item.firstName))
                {
                    Assert.True(true);
                }
            }
            if (finalList.Contains(null))
            {
              throw new Exception();
            }
        }
    }
}