using System;

public class IndividualReviewer
{
	public int id;
	public string name;
	public string areaOfExpertise;
	public bool availability;

	public IndividualReviewer(int id, string name, string areaOfExpertise, bool availability)
	{
		this.id = id;
		this.name = name;
		this.areaOfExpertise = areaOfExpertise;
		this.availability = availability;
	}

    public int ReviewAndScoreIdea()
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

    public List<Idea> ClassifyIdeas(Idea idea)
    {
        if (ReviewAndScoreIdea() >= 12)
        {
            Ideaspool acceptedIdeas.Add(idea);
            return acceptedIdeas;
        }
        else
        {
            IdeasPool rejectedIdeas.Add(idea);
            return rejectedIdeas
        }

        IdeasPool reviewedIdeas.Add(idea);
        return reviewedIdeas;

    }
}
