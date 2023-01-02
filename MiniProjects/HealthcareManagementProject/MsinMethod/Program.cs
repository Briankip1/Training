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


        HealthPractitioner one = new HealthPractitioner("Brian", "Davids", "briandavids@gmail.com", "Physician", "+12234657656", "HCP23573", "2756 Ranchview Ln N");
        // Console.WriteLine(one.CreatePatientRecord();

        HealthFacility newHealthFacility = new("Park Nicollet", "Health Center", "HF9574");
        newHealthFacility.CreateVisitRecord(one, patient1, "The patient complained of headache and chestpains", DateTime.Now);
        //VisitRecords newRecord = new VisitRecords();
        //newHealthFacility.visits.Add(newRecord);


        HealthFacility healthFacility  = new("Hennepin Healthcare", "Health Center", "HC5699");
        healthFacility.CreateVisitRecord(one, patient1,"The patient complained of stomach upsets and diarrhoea", DateTime.Today);
        //VisitRecords record = new VisitRecords();


        for (int i = 0; i < healthFacility.visits.Count; i++)
        {
            Console.WriteLine(healthFacility.visits[i]);
        }

        healthFacility.Patients.Add(patient1);
        foreach(Patient patient in healthFacility.Patients)
        {
            Console.WriteLine(patient.ToString());
        }
        Console.ReadLine();
    }
}
