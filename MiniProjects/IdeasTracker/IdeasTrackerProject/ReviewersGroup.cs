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
        Random random = new Random();
        Dictionary<Idea, List<IndividualReviewer>> assignedIdeas = new Dictionary<Idea, List<IndividualReviewer>>();
        while(availableIdeas.Count > 0)
		{
            List<IndividualReviewer> assignedReviewers = new List<IndividualReviewer>();

			foreach(Idea idea in availableIdeas)
			{
                for (int i = 0; i < 2; i++)
                {
                    int reviewerIndex = random.Next(reviewers.Count);
                    IndividualReviewer reviewer = reviewers[reviewerIndex];
                    assignedReviewers.Add(reviewer);
                    reviewers.RemoveAt(reviewerIndex);
                }
                assignedIdeas.Add(idea, assignedReviewers);
				availableIdeas.Remove(idea);
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
