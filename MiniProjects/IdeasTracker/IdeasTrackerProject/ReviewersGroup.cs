using IdeasTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Principal;

public class ReviewersGroup : IdeaStakeholders
{	
    public List<IndividualReviewer> availableReviewers = new List<IndividualReviewer>();
    public Dictionary<Idea, List<IndividualReviewer>> ideaAndAssignedReviewers = new Dictionary<Idea, List<IndividualReviewer>>();

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

	public ReviewersGroup(string areaOfExpertise, bool availability, int yearsOfExperience) : base(areaOfExpertise, availability, yearsOfExperience)
	{
		
	}
	
    public void AssignIdeasForReview(IdeasPool availableIdeas)
	{
        Random random = new Random();
        
        
		for( int j = 0; j < availableIdeas.enteredIdeas.Count; j++)
		{

            Idea latestIdea = availableIdeas.enteredIdeas[j];
			List<IndividualReviewer> twoReviewers = new List<IndividualReviewer>();
            for (int i = 0; i < 2; i++)
            {
                int reviewerIndex = random.Next(availableReviewers.Count);
                IndividualReviewer chosenReviewer = availableReviewers[reviewerIndex];
				chosenReviewer.assignedIdeas.Add(latestIdea);
					twoReviewers.Add(chosenReviewer);		                   
            }
            ideaAndAssignedReviewers.Add(latestIdea, twoReviewers);
        }
        while (availableIdeas.enteredIdeas.Count > 0)
        {
			Idea freshIdea = availableIdeas.enteredIdeas[0];
            availableIdeas.enteredIdeas.Remove(freshIdea);
        }
	}

	public void ProvideFeedBack()
	{

	}
}
