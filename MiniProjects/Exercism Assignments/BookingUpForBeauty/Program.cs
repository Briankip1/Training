// See https://aka.ms/new-console-template for more information
using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (DateTime.Now > appointmentDate)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {

        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
