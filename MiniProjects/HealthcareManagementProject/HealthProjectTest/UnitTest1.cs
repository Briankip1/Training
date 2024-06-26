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
            HealthFacility AmazingHosp = new HealthFacility("AmazingHosp");
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

            finalList.Intersect(anotherDataBank.Patients);
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

        [Fact]
        public void Test3()
        {

            Guid practitionerGuid = Guid.NewGuid();
            Patient newpatient = new Patient("Mark", "Wayne");

            Patient Eric = new Patient("Eric", "Johns");
            Patient Jack = new Patient("Jack", "Willis");
            Patient Hannah = new Patient("Hannah", "Maine");
            Patient Robert = new Patient("Robert", "Kelly");


            HealthFacility parkNicollet = new("Park Nicollet");

            HealthFacility hennepinHealthcare = new("Hennepin Healthcare");

            DataBank dataBank = new DataBank("AWS", "AWS2543");

            HealthPractitioner physicianBrian = new HealthPractitioner("Brian", "Davids");
            HealthPractitioner nurseLucy = new HealthPractitioner("Lucy", "Wayne");
            HealthPractitioner doctorDwayne = new HealthPractitioner("Dwayne", "Mattis");
            HealthPractitioner radiologistVincent = new HealthPractitioner("Vincent", "Kompany");

            var newPatientVisit = new VisitRecords("description", practitionerGuid, newpatient);


            var dataBankOne = new DataBank("Amazon", "AMZ1234");

            dataBankOne.CreateAndStore(Robert, physicianBrian, parkNicollet);
            dataBankOne.CreateAndStore(Hannah, nurseLucy, hennepinHealthcare);
            dataBankOne.CreateAndStore(Jack, doctorDwayne, parkNicollet);
            dataBankOne.CreateAndStore(Robert, radiologistVincent, hennepinHealthcare);
         



            dataBankOne.JoinPractitionersAndVisits();

            if (physicianBrian.Id != newPatientVisit.practitionerId)
            {
                throw new Exception();
            }
            
        }

    }
}