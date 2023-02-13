using HealthRecordsManagementProject;

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
            var testingStorage = newStorage.Store(newpatient, doctorDan, AmazingHosp);

            var newPatientVisit = new VisitRecords("description", practitionerGuid, newpatient);

            if(newPatientVisit.description is string)
            {
                throw new Exception();
            }
            if(newPatientVisit.practitionerId != practitionerGuid)
            {
                throw new Exception();
            }

            if(newpatient.id != testingStorage.patientId)
            {
                throw new Exception();

            }




        }
    }
}