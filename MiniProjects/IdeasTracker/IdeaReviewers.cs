using IdeasTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

public class IdeaReviewers
{
	
	public string areaOfExpertise;
	public bool availability;
	public int yearsOfExperience;

	public IdeaReviewers(string areaOfExpertise, bool availability, int yearsOfExperience) 
	{
		this.areaOfExpertise = areaOfExpertise;
		this.availability = availability;
		this.yearsOfExperience= yearsOfExperience;
		
	}


	public void AssignideasForReview(string reviewerName)
	{
		if(IdeaPool category.Contains(areaOfExpertise))
		{
			foreach(string idea in IdeaPool.enteredIdeas)
			{
				Console.WriteLine(idea + " " + reviewerName);

			}
		}

	}

	public List<IdeaPool> ReviewAndScoreIdea(IdeaPool oneIdea)
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
			IdeaPool acceptedIdeas.Add(oneIdea);

        }
		else
		{
			IdeaPool rejectedIdeas.Add(oneIdea);
		}

		IdeaPool reviewedIdeas.Add(oneIdea);
		return reviewedIdeas;


    }

	public void ProvideFeedBack()
	{

	}

	public void AddReviewers()
	{

	}
}
