using IdeasTracker;
using System;
using System.Security.Principal;

public class IdeaReviewer
{
	public string ReviewerName;
	public string fieldofExperience;
	public List<string>ReviewersList;
	public List<Idea> reviewedIdeas;
	public List<Idea> AcceptedIdeas;
	public List<Idea> rejectedIdeas;
	public DateTime estimatedTimeline;

	public void ReviewAndScoreIdea()
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
			AcceptedIdeas.Add();

        }








    }

	public void VoteIdea()
	{
		int totalScore = 0;

        totalScore = timescore + cost + potentialImpact + monetaryImpact;

        if (totalScore > 12)
        {

        }
    }

	public void ProvideFeedBack()
	{

	}

	public void AddReviewers()
	{

	}
}
