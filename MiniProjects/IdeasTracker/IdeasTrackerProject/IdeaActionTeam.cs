using IdeasTracker;
using System;
using System.Security.Cryptography;

public class IdeasActionTeam
{
	public List<Idea> IdeasInProgress = new List<Idea>();
	public List<Idea> CompletedIdeas = new List<Idea>();
	public List<Professional> AvailableActionTeam = new List<Professional>();
	public Dictionary<Idea, Professional> assignedProjectsAndProfessionals = new Dictionary<Idea, Professional>();
	public IdeasActionTeam()
	{
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
                availableProfessional.assignedProjects.Add(oneIdea);
                assignedProjectsAndProfessionals.Add(oneIdea, availableProfessional);
				availableProfessional.availability = false;
			}
		}
        while (approvedIdeas.acceptedIdeas.Count > 0)
        {
            Idea freshIdea = approvedIdeas.acceptedIdeas[0];
            approvedIdeas.acceptedIdeas.Remove(freshIdea);
        }
    }


	public void GenerateProjectReport()
	{

	}

}
