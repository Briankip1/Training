using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IdeasTracker
{
  
    public interface IConsole
    {
        Idea IdeaEntry(Idea idea);
        void WriteLine(string text);
        string ReadLine();

    }
    public class IdeasPool : IUniqueId, IConsole
    {
        public Guid id { get; set; }
        public DateTime timeframe;
        public string priority;
        public List<Tuple<Idea,string>>enteredIdeas = new();
        public List<Idea> reviewedIdeas = new List<Idea>();
        public List<Idea> acceptedIdeas = new List<Idea>();
        public List<Idea> rejectedIdeas = new List<Idea>();
        public List<string> category = new List<string>() { "ArtsandEntertainment", "Marketing", "ContentMarketing", "Design", "FoodAndHospitality", "Writing", "SportAndFitness", "Technology" };



        public IdeasPool(DateTime date, string priority)
        {

            this.timeframe = DateTime.Now;
            this.priority = priority;
        }

        public Idea IdeaEntry(Idea idea, IConsole console)
        {
            console.WriteLine("Enter title name:");
            idea.title = console.ReadLine();
            console.WriteLine("Enter idea description:");
            idea.description = console.ReadLine();
            console.WriteLine("Enter idea sponsor");
            idea.sponsor = console.ReadLine();
            console.WriteLine("Enter the date:");
            idea.date = DateTime.Now;
            console.WriteLine("Enter the category: ");
            idea.enteredCategory = console.ReadLine(); 
            return idea;
        }

        public (Idea, string) CheckAndAddIdeaCategory(Idea someIdea)
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
                var combinedIdea = new Tuple<Idea, string>(someIdea, userInput);
                return combinedIdea;

            }
            else
            {
                return (IdeaEntry(someIdea), "Other");
            }
        }

        public void AddNewIdeatoEnteredIdeas(Idea idea)
        {
            enteredIdeas.Add(CheckAndAddIdeaCategory(idea));
        }

        public double AverageIdeaScore(Idea idea)
        {

            foreach (int eachScore in idea.ideasScores)
            {
                idea.cumulativeIdeaScore += eachScore;

                idea.cumulativeIdeaAverage = idea.cumulativeIdeaScore / idea.ideasScores.Count;
            }
            return idea.cumulativeIdeaAverage;
        }

        public void ClassifyIdea(Idea idea)
        {
            if (AverageIdeaScore(idea) >= 12)
            {
                acceptedIdeas.Add(idea);               
            }
            if (AverageIdeaScore(idea) < 12)
            {
                rejectedIdeas.Add(idea);               
            }
             reviewedIdeas.Add(idea);
        }

        
    }
}