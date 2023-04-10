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

    public int ReviewAndScoreIdea(Idea idea)
    {
        int totalScore = 0;

        Console.WriteLine("Evaluation Matrix - Points(1- 5)");

        Console.WriteLine("Enter Time Score: ");
        int timescore = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Cost Score: ");
        int cost = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Score for Potential Impact: ");
        int potentialImpact = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Monetary Impact Score: ");
        int monetaryImpact = Convert.ToInt32(Console.ReadLine());

        totalScore = timescore + cost + potentialImpact + monetaryImpact;
        return totalScore;
    }

    public void AddScore(IdeasPool pool)
    {
        pool.ideasScores.Add(ReviewAndScoreIdea(new Idea()));

    }

    
}
