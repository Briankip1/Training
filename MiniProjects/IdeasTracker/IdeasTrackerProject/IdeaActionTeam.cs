using IdeasTracker;
using System;

public class IdeasActionTeam : IdeaStakeholders
{
	public DateTime estimatedProjectTimeline;
	public List<Idea> IdeasInProgress = new List<Idea>();
	public List<Idea> CompletedIdeas = new List<Idea>();
	public List<string> AvailableActionTeam = new List<string>();
	public IdeasActionTeam(string areaOfExpertise, bool availability, int yearsOfExperience): base(areaOfExpertise, availability, yearsOfExperience)
	{
		estimatedProjectTimeline = new DateTime().AddDays(5);

	}
	public void AssignProject()
	{

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
