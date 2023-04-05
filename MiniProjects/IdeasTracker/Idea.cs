using IdeasTracker;
using System;
using System.Transactions;

public interface IAddIdeas
{
	void AddIdea();
}
public interface IUniqueId
{
	Guid id { get; }
}

public class Idea : IAddIdeas, IUniqueId
{
	public Guid id{ get; set; }
	public string title;
	public string description;
	public string sponsor;
	public DateTime date;
    public List<string> enteredIdeas = new List<string>();
    List<string> category = new List<string>() {"ArtsandEntertainment", "Marketing", "ContentMarketing", "Design", "FoodAndHospitality", "Writing", "SportAndFitness", "Technology"};


    public Idea(string title, string description, string sponsor, DateTime date)
	{
		this.title = title;
		this.description = description;
		this.sponsor = sponsor;
		this.date = date;
	}

	public string IdeaEntry()
	{
		Console.WriteLine("Enter title name:");
		title = Console.ReadLine();
		Console.WriteLine("Enter idea description:");
		description = Console.ReadLine();
		Console.WriteLine("Enter idea sponsor");
		sponsor = Console.ReadLine();
		Console.WriteLine("Enter the date:");
		date = DateTime.Now;

		return $" {id} {title} {description} {sponsor} {date}";
	}

	public string CheckAndAddIdeaCategory()
	{
        Console.WriteLine("Choose category based on the list below:");
        Console.WriteLine(
		"ArtsandEntertainment\n",
		"Marketing\n",
		"ContentMarketing\n",
		"Design\n",
		"FoodAndHospitality\n",
		"Writing\n",
		"SportAndFitness\n",
		"Technology");

        string? userInput = Console.ReadLine();
        if (category.Contains(userInput))
        {
            return $"{IdeaEntry()} : {userInput}";
        }
        else
        {
            return $"{IdeaEntry()} : Other";
        }
	}

	public void AddIdea()
	{
		enteredIdeas.Add(CheckAndAddIdeaCategory());
	}
}
