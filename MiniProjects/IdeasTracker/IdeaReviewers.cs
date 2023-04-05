using IdeasTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

public class IdeaReviewers
{
	
	public string areaOfExpertise;
	public bool availability;
	public int yearsOfExperience;
	public Dictionary<string, string> matchingSpecializations = new Dictionary<string, string>()
	{
		{"ArtsandEntertainment", "artist" },
		{ "Marketing", "marketing professional"},
		{ "ContentMarketing", "content marketer"},
		{ "Design", "designer"},
		{ "FoodAndHospitality", "restaurant manager"},
		{"Writing", "author"},
		{"SportAndFitness", "fitness instructor"},
		{"Technology", "software engineer" }
	};

	public IdeaReviewers(string areaOfExpertise, bool availability, int yearsOfExperience) 
	{
		this.areaOfExpertise = areaOfExpertise;
		this.availability = availability;
		this.yearsOfExperience= yearsOfExperience;
		
	}


	public string AssignideasForReview()
	{
		if(Idea.enteredIdeas.Contains(matchingSpecializations.Keys))
		{
			foreach(string idea in Idea.enteredIdeas)
			{
				return $"{guid} = {matchingSpecializations.Values}";
			}			
		}
		return null;

	}

	public void ProvideFeedBack()
	{

	}

	public void AddReviewers()
	{

	}
}
