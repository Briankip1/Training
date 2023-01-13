// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HealthRecordsManagementProject;
using System;
using System.Security.Cryptography.X509Certificates;

public class MainClass
{
    public static void Main(string[] args)
    {
        Patient patient1 = new Patient("Eric", "Johns", "ericjohns@gmail.com", "+123455678", "UI23455", "2334 Lanor Lake");
        Patient patient2 = new Patient("Jack", "Willis", "willisjack@gmail.com","+15698395", "UI68798", "2346 Carlson Pkwy");


        HealthPractitioner physician = new HealthPractitioner("Brian", "Davids", "briandavids@gmail.com", "Physician", "+12234657656", "2756 Ranchview Ln N");
        HealthPractitioner nurse = new HealthPractitioner("Lucy", "Wayne", "waynelucy@gmail.com", "nurse", "+130984738", "264 Ave N Plymouth");
        HealthPractitioner doctor = new HealthPractitioner("Dwayne", "Mattis", "mattis@gmail.com", "doctor", "+130984734", "296 Ave N Anoka");
        HealthPractitioner radiologist = new HealthPractitioner("vincent", "Kompany", "kompany@gmail.com", "radiologist", "+130934899", "301 Dr Blaine");

        // Console.WriteLine(one.CreatePatientRecord();

        HealthFacility parkNicollet = new("Park Nicollet", "Health Center", "HF9574");
        parkNicollet.CreateVisitRecord(physician, patient1);
        //VisitRecords newRecord = new VisitRecords();
        //newHealthFacility.visits.Add(newRecord);


        HealthFacility hennepinHealthcare  = new("Hennepin Healthcare", "Health Center", "HC5699");
        hennepinHealthcare.CreateVisitRecord(physician, patient1);
        //VisitRecords record = new VisitRecords();


        for (int i = 0; i < hennepinHealthcare.HealthFacilityVisits.Count; i++)
        {
            Console.WriteLine(hennepinHealthcare.HealthFacilityVisits[i]);
        }

        hennepinHealthcare.Patients.Add(patient1);
        hennepinHealthcare.Patients.Add(patient2);
        hennepinHealthcare.HealthPractitioners.Add(physician);
        hennepinHealthcare.HealthPractitioners.Add(nurse);
        hennepinHealthcare.HealthPractitioners.Add(doctor);
        hennepinHealthcare.HealthPractitioners.Add(radiologist);
        foreach(HealthPractitioner one in hennepinHealthcare.HealthPractitioners)
        {
            Console.WriteLine( one);
        }
        hennepinHealthcare.RetrievePractitioners();

        DataBank dataBank = new DataBank("AWS","AWS2543");
        dataBank.Store();
       
        Console.ReadLine();
    }
}
