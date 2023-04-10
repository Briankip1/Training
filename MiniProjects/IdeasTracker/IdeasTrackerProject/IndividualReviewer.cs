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
        

        Console.WriteLine("Evaluation Matrix - Points(1- 5)");

        Console.WriteLine("Enter Time Score: ");
        idea.timeScore = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Cost Score: ");
        idea.cost = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Score for Potential Impact: ");
        idea.potentialImpact = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Monetary Impact Score: ");
        idea.monetaryImpact = Convert.ToInt32(Console.ReadLine());

        idea.totalScore = idea.timeScore + idea.cost + idea.potentialImpact + idea.monetaryImpact;
        return idea.totalScore;
    }

    public void AddScore(IdeasPool pool)
    {
        pool.ideasScores.Add(ReviewAndScoreIdea(new Idea()));

    }

    
}
