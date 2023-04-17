using IdeasTracker;
using System;

public class IndividualReviewer: IUniqueId, IConsole
{
	public Guid id { get; set; }
	public string name;
	public string areaOfExpertise;
	public bool availability;
    

    public IndividualReviewer(string name, string areaOfExpertise, bool availability)
	{
		this.name = name;
		this.areaOfExpertise = areaOfExpertise;
		this.availability = availability;
	}

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }

    public int ReviewAndScoreIdea(IdeaScore score, Idea idea, IConsole console)
    {
        
   console.WriteLine("Evaluation Matrix - Points(1- 5)");

        console.WriteLine("Enter Time Score: ");
        score.timeScore = Convert.ToInt32(console.ReadLine());

        console.WriteLine("Enter Cost Score: ");
        score.cost = Convert.ToInt32(console.ReadLine());

        console.WriteLine("Enter Score for Potential Impact: ");
        score.potentialImpact = Convert.ToInt32(console.ReadLine());

        console.WriteLine("Enter Monetary Impact Score: ");
        score.monetaryImpact = Convert.ToInt32(console.ReadLine());

        score.totalScore = score.timeScore + score.cost + score.potentialImpact + score.monetaryImpact;

        idea.ideaScores.Add(score);
        return score.totalScore;
    }
}


