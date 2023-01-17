// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HealthRecordsManagementProject;
using System;
using System.Security.Cryptography.X509Certificates;

public class MainClass
{
    public static void Main(string[] args)
    {
        Patient patient1 = new Patient("Eric", "Johns", "ericjohns@gmail.com", "+123455678", "UI23455" );
        Patient patient2 = new Patient("Jack", "Willis", "willisjack@gmail.com","+15698395", "UI68798");
        Patient patient3 = new Patient("Hannah", "Maine", "hannah@gmail.com", "+103953646", "UI02437");
        Patient patient4 = new Patient("Robert", "Kelly", "kelly@gmail.com", "+1348593025", "UI0392");


        HealthPractitioner physician = new HealthPractitioner("Brian", "Davids", "briandavids@gmail.com", "Physician", "+12234657656", "2756 Ranchview Ln N");
        HealthPractitioner nurse = new HealthPractitioner("Lucy", "Wayne", "waynelucy@gmail.com", "nurse", "+130984738", "264 Ave N Plymouth");
        HealthPractitioner doctor = new HealthPractitioner("Dwayne", "Mattis", "mattis@gmail.com", "doctor", "+130984734", "296 Ave N Anoka");
        HealthPractitioner radiologist = new HealthPractitioner("vincent", "Kompany", "kompany@gmail.com", "radiologist", "+130934899", "301 Dr Blaine");


        HealthFacility parkNicollet = new("Park Nicollet", "Health Center", "HF9574");
        parkNicollet.CreateVisitRecord(physician, patient1);
       
        HealthFacility hennepinHealthcare  = new("Hennepin Healthcare", "Health Center", "HC5699");
        hennepinHealthcare.CreateVisitRecord(physician, patient1);
        //VisitRecords record = new VisitRecords();

        DataBank dataBank = new DataBank("AWS","AWS2543");

        dataBank.HealthPractitioners.Add(physician);
        dataBank.HealthPractitioners.Add(nurse);
        dataBank.HealthPractitioners.Add(doctor);
        dataBank.HealthPractitioners.Add(radiologist);

        dataBank.RetrievePractitioners();

        dataBank.Patients.Add(patient1);
        dataBank.Patients.Add(patient2);
        dataBank.Patients.Add(patient3);
        dataBank.Patients.Add(patient4);

        dataBank.RetrievePatient();

        dataBank.facilityList.Add(parkNicollet);
        dataBank.facilityList.Add(hennepinHealthcare);

        dataBank.RetrievePatient();

        dataBank.visits.Add(parkNicollet.CreateVisitRecord(physician,patient1));
        dataBank.visits.Add(hennepinHealthcare.CreateVisitRecord(radiologist,patient2));




        for (int i = 0; i < dataBank.visits.Count; i++)
        {
            Console.WriteLine(dataBank.visits[i]);
        }


        foreach (HealthPractitioner one in dataBank.HealthPractitioners)
        {
            Console.WriteLine(one);
        }

        Console.ReadLine();
    }
}
