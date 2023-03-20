using IdeasTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

public class IdeaReviewer
{
	public string ReviewerName;
	public string Specialization;
	public List<string>ReviewersList;
	public List<Idea> reviewedIdeas;
	public List<Idea> acceptedIdeas;
	public List<Idea> rejectedIdeas;
	public DateTime estimatedTimeline;


	public List<string> ReviewAndScoreIdea(Idea oneIdea)
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

        if (totalScore >= 12)
        {
			acceptedIdeas.Add(oneIdea);

        }
		else
		{
			rejectedIdeas.Add(oneIdea);
		}

	return 	reviewedIdeas.Add(oneIdea);


    }

	public void ProvideFeedBack()
	{

	}

	public void AddReviewers()
	{

	}
}
