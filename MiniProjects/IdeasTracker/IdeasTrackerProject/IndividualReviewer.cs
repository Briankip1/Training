﻿using IdeasTracker;
using System;
using System.Security.Cryptography;

public class IndividualReviewer: IdeaStakeholders, IUniqueId
{
	public Guid id { get; set; }
    public string name;
    public List<Idea> assignedIdeas = new List<Idea>();
    

    public IndividualReviewer(string name, string areaOfExpertise, bool availability, int yearsOfExperience): base(areaOfExpertise, availability, yearsOfExperience)
	{
		this.name = name;
		this.areaOfExpertise = areaOfExpertise;
		this.availability = availability;
	}

    public IdeaScore ReviewAndScoreIdea(IdeaScore score, Idea idea, IConsole console)
    {
        console.WriteLine("Evaluation Matrix - Points(1- 5)");

        console.WriteLine("Enter Cost Score: ");
        score.cost = Convert.ToInt32(console.ReadLine());

        console.WriteLine("Enter Score for Potential Impact: ");
        score.potentialImpact = Convert.ToInt32(console.ReadLine());

        console.WriteLine("Enter Monetary Impact Score: ");
        score.monetaryImpact = Convert.ToInt32(console.ReadLine());

        score.totalScore = score.timeScore + score.cost + score.potentialImpact + score.monetaryImpact;
        idea.ideaScores.Add(score);
        return score;     
    }

    public void ProvideFeedback()
    {

    }

    public void GenerateReport()
    {

    }
}


