// See https://aka.ms/new-console-template for more information
using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
                break;
            case 3:
                return "center back";
                break;
            case 4:
                return "center back";
                break;
            case 5:
                return "right back";
                break;
            case 6:
                return "midfielder";
                break;
            case 7:
                return "midfielder";
                break;
            case 8:
                return "midfielder";
                break;
            case 9:
                return "left wing";
                break;
            case 10:
                return "striker";
                break;
            case 11:
                return "right wing";
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string AnalyzeOffField(object report)
    {

        switch (report)
        {
            case int supporters:
                return $"There are {supporters} supporters at the match.";
                break;
            case string announcements:
                return announcements;
                break;
            case Injury newInjury:
                return $"Oh no! {newInjury.GetDescription()} Medics are on the field.";
                break;
            case Incident newIncident:
                return newIncident.GetDescription();
                break;
            case Manager manager:
                return manager.Club == null ? manager.Name : $"{manager.Name} ({manager.Club})";
                break;
            default:
                throw new ArgumentException();
        }
    }
}