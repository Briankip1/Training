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
    public List<IndividualReviewer> availableReviewers = new List<IndividualReviewer>();
    public Dictionary<Idea, List<IndividualReviewer>> assignedReviewers = new Dictionary<Idea, List<IndividualReviewer>>();

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
	
    public void AssignIdeasForReview(IdeasPool availableIdeas, IndividualReviewer reviewer)
	{
        Random random = new Random();
        
        while (availableIdeas.enteredIdeas.Count > 0)
		{
			for( int j = 0; j < availableIdeas.enteredIdeas.Count; j++)
			{

                Idea latestIdea = availableIdeas.enteredIdeas[j];
				List<IndividualReviewer> twoReviewers = new List<IndividualReviewer>();
                for (int i = 0; i < 2; i++)
                {
                    int reviewerIndex = random.Next(availableReviewers.Count);
                    IndividualReviewer chosenReviewer = availableReviewers[reviewerIndex];
					 twoReviewers.Add(chosenReviewer);		                   
                }
                assignedReviewers.Add(latestIdea, twoReviewers);
                reviewer.assignedIdeas.Add(latestIdea);
                availableIdeas.enteredIdeas.Remove(latestIdea);
            }       
		}
	}

	public void ProvideFeedBack()
	{

	}
}
