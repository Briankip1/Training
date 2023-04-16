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
	public double cumulativeIdeaAverage = 0;
	public string enteredCategory;
	public List<IdeaScore> ideaScores = new List<IdeaScore>();
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
