using HealthRecordsManagementProject;
using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Patient patient1 = new Patient("Eric", "Johns", "ericjohns@gmail.com", "+123455678", "UI23455", "2334 Lanor Lake", "Diagnostic results returned Pneumonia");
        HealthCareProvider one = new HealthCareProvider("Brian", "Davids", "briandavids@gmail.com", "Physician", "+12234657656", "HCP23573", "2756 Ranchview Ln N");
        Console.WriteLine(one.CreatePatientRecord());

    }
}
