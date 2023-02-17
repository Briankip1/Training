// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HealthRecordsManagementProject;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class MainClass
{
    public static void Main(string[] args)
    {
        Patient Eric = new Patient("Eric", "Johns");
        Patient Jack = new Patient("Jack", "Willis");
        Patient Hannah = new Patient("Hannah", "Maine");
        Patient Robert = new Patient("Robert", "Kelly");


        HealthPractitioner physicianBrian = new HealthPractitioner("Brian", "Davids");
        HealthPractitioner nurseLucy = new HealthPractitioner("Lucy", "Wayne");
        HealthPractitioner doctorDwayne = new HealthPractitioner("Dwayne", "Mattis");
        HealthPractitioner radiologistVincent = new HealthPractitioner("Vincent", "Kompany");



        HealthFacility parkNicollet = new("Park Nicollet", "Health Center", "HF9574");
       
        HealthFacility hennepinHealthcare  = new("Hennepin Healthcare", "Health Center", "HC5699");

        DataBank dataBank = new DataBank("AWS","AWS2543");

        dataBank.CreateAndStore(Robert, physicianBrian, parkNicollet);
        dataBank.CreateAndStore(Hannah, nurseLucy,hennepinHealthcare);
        dataBank.CreateAndStore(Jack, doctorDwayne, parkNicollet);
        dataBank.Patients.Add(Eric);
        //dataBank.Store(Eric, radiologistVincent, hennepinHealthcare);

        //dataBank.RetrievePractitioners();

       // dataBank.RetrievePatient();

        //dataBank.RetrieveVisits();

        //dataBank.JoinPatientsAndVisits();


       //for (int i = 0; i < dataBank.visits.Count; i++)
       //{
       //     Console.WriteLine(dataBank.visits[i]);
       //}

        Console.ReadLine();
    }
}
