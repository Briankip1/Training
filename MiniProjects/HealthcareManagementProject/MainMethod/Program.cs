// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HealthRecordsManagementProject;
using System;
using System.Security.Cryptography.X509Certificates;

public class MainClass
{
    public static void Main(string[] args)
    {
        Patient Eric = new Patient("Eric", "Johns");
        Patient Jack = new Patient("Jack", "Willis");
        Patient Hannah = new Patient("Hannah", "Maine");
        Patient Robert = new Patient("Robert", "Kelly");


        HealthPractitioner physician = new HealthPractitioner("Brian", "Davids");
        HealthPractitioner nurse = new HealthPractitioner("Lucy", "Wayne");
        HealthPractitioner doctor = new HealthPractitioner("Dwayne", "Mattis");
        HealthPractitioner radiologist = new HealthPractitioner("vincent", "Kompany");



        HealthFacility parkNicollet = new("Park Nicollet", "Health Center", "HF9574");
       
        HealthFacility hennepinHealthcare  = new("Hennepin Healthcare", "Health Center", "HC5699");

        DataBank dataBank = new DataBank("AWS","AWS2543");

        dataBank.HealthPractitioners.Add(physician);
        dataBank.HealthPractitioners.Add(nurse);
        dataBank.HealthPractitioners.Add(doctor);
        dataBank.HealthPractitioners.Add(radiologist);
        

        dataBank.RetrievePractitioners();

        dataBank.Patients.Add(Eric);
        dataBank.Patients.Add(Jack);
        dataBank.Patients.Add(Hannah);
        dataBank.Patients.Add(Robert);

        dataBank.RetrievePatient();

        dataBank.facilityList.Add(parkNicollet);
        dataBank.facilityList.Add(hennepinHealthcare);


        dataBank.visits.Add(parkNicollet.CreateVisitRecord(physician.Id, Eric));
        dataBank.visits.Add(hennepinHealthcare.CreateVisitRecord(radiologist.Id, Jack));
        dataBank.visits.Add(parkNicollet.CreateVisitRecord(nurse.Id, Hannah));
        dataBank.visits.Add(hennepinHealthcare.CreateVisitRecord(doctor.Id, Eric));

        var query =
            from patient in Patients
            join visit in visits on patient.id equals visit.patientId into joinedList
            //from subPatient in joinedList.DefaultIfEmpty()
            select new
            {
                patient.id,
                patient.firstName,
                description = " " ? :string.Empty
            };

        foreach (var item in query)
        {
            Console.WriteLine($"{item.id} {item.firstName} {item.description} ");
        }





        dataBank.RetrieveVisits();


        for (int i = 0; i < databank.visits.count; i++)
        {
            console.writeline(databank.visits[i]);
        }


        foreach (HealthPractitioner one in dataBank.HealthPractitioners)
        {
            Console.WriteLine(one);
        }

        Console.ReadLine();
    }
}
