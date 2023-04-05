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

	

	public void ProvideFeedBack()
	{

	}

	public void AddReviewers()
	{

	}
}
