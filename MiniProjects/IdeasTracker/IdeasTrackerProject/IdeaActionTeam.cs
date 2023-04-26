using IdeasTracker;
using System;
using System.Security.Cryptography;

public class IdeasActionTeam : IdeaStakeholders
{
	public DateTime estimatedProjectTimeline;
	public List<Idea> IdeasInProgress = new List<Idea>();
	public List<Idea> CompletedIdeas = new List<Idea>();
	public List<Professional> AvailableActionTeam = new List<Professional>();
	public Dictionary<Idea, Professional> projectsAndProfessionals = new Dictionary<Idea, Professional>();
	public IdeasActionTeam(string areaOfExpertise, bool availability, int yearsOfExperience): base(areaOfExpertise, availability, yearsOfExperience)
	{
		estimatedProjectTimeline = new DateTime().AddDays(5);

	}
	public void AssignProject(IdeasPool approvedIdeas)
	{
		Random random = new Random();
		for(int i = 0; i < approvedIdeas.acceptedIdeas.Count; i++)
		{
			Idea oneIdea = approvedIdeas.acceptedIdeas[i];
			for(int j = 0; j < AvailableActionTeam.Count; j++)
			{
				int randomIndex = random.Next(AvailableActionTeam.Count);
				Professional availableProfessional = AvailableActionTeam[randomIndex];
				projectsAndProfessionals.Add(oneIdea, availableProfessional);
				availableProfessional.assignedProjects.Add(oneIdea);
			}
		}
		approvedIdeas.acceptedIdeas.Clear();
	}

	public void SetProjectTimeline()
	{

	}

	public void UpdateOnProgress()
	{

	}

	public void DetermineProjectFate()
	{

	}

	public void GenerateProjectReport()
	{

	}

}
