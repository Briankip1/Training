using IdeasTracker;
using System;

public class IndividualReviewer: IUniqueId
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

    public int ReviewAndScoreIdea(IdeaScore score, Idea idea)
    {
        
   Console.WriteLine("Evaluation Matrix - Points(1- 5)");

        Console.WriteLine("Enter Time Score: ");
        score.timeScore = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Cost Score: ");
        score.cost = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Score for Potential Impact: ");
        score.potentialImpact = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Monetary Impact Score: ");
        score.monetaryImpact = Convert.ToInt32(Console.ReadLine());

        score.totalScore = score.timeScore + score.cost + score.potentialImpact + score.monetaryImpact;

        idea.ideaScores.Add(score);
        return score.totalScore;
    }
}


