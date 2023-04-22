using IdeasTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Principal;

public class ReviewersGroup
{
	
	public string areaOfExpertise;
	public bool availability;
	public int yearsOfExperience;
	public List<IndividualReviewer> assignedReviewers = new List<IndividualReviewer>();

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
	public void AssignIdeasForReview(List<Idea> availableIdeas, List<IndividualReviewer> reviewers, IndividualReviewer reviewer)
	{
        Random random = new Random();
        while(availableIdeas.Count > 0)
		{
			foreach(Idea latestIdea in availableIdeas)
			{
                for (int i = 0; i < 2; i++)
                {
                    int reviewerIndex = random.Next(reviewers.Count);
                    reviewer = reviewers[reviewerIndex];
					assignedReviewers.Add(reviewer);
					reviewers.Remove(reviewer);
				}
                reviewer.assignedIdeas.Add(latestIdea);
				availableIdeas.Remove(latestIdea);
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
