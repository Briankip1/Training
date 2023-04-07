using IdeasTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

public class ReviewersGroup
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

	public ReviewersGroup(string areaOfExpertise, bool availability, int yearsOfExperience) 
	{
		this.areaOfExpertise = areaOfExpertise;
		this.availability = availability;
		this.yearsOfExperience= yearsOfExperience;
		
	}
	public List<Idea> AssignIdeasForReview(List<Idea> availableIdeas, List<IndividualReviewer> reviewers)
	{
		foreach (Idea idea in availableIdeas)
		{
			foreach(IndividualReviewer reviewer in reviewers)
			{
				Dictionary<Idea, IndividualReviewer> pairs = new Dictionary<Idea, IndividualReviewer>();
				pairs.Add(idea, reviewer);
			}
		}
		
		return null;
	}

	//public string AssignideasForReview(IdeasPool pool)
	//{
	//	if(pool.enteredIdeas.Contains(matchingSpecializations.Keys))
	//	{
	//		foreach(Idea idea in pool.enteredIdeas)
	//		{
	//			return $"{idea}{matchingSpecializations.Values}";
	//		}			
	//	}
	//	return null;
	//}

	public void ProvideFeedBack()
	{

	}

	public void AddReviewers()
	{

	}
}
