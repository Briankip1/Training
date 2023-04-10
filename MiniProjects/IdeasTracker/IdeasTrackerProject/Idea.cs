using IdeasTracker;
using System;
using System.Net.Sockets;
using System.Transactions;

public interface IUniqueId
{
	Guid id { get; }
}

public class Idea : IUniqueId
{
	public Guid id{ get; set; }
	public Guid individualReviewerId; 
	public string title;
	public string description;
	public string sponsor;
	public DateTime date;
    public int totalScore = 0;
    public int timeScore = 0;
	public int cost = 0;
	public int potentialImpact = 0;
	public int monetaryImpact = 0;
	public int cumulativeIdeaScore = 0;
	public double cumulativeIdeaAverage = 0;



    public Idea()
	{
		
	}
    public Idea(string title, string description, string sponsor, DateTime date)
	{
		this.title = title;
		this.description = description;
		this.sponsor = sponsor;
		this.date = date;
	}
}
