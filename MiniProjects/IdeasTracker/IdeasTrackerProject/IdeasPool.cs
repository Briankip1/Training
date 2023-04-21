using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IdeasTracker
{
  
    public interface IConsole
    {
        void WriteLine(string text);
        string ReadLine();
    }
    
    public class IdeasPool : IUniqueId
    {
        public Guid id { get; set; }
        public DateTime timeframe;
        public string priority;
        public List<Idea>enteredIdeas = new List<Idea>();
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

        public double AverageIdeaScore(Idea idea)
        {
            int cumulativeIdeaScore = 0;
            foreach (IdeaScore eachScore in idea.ideaScores)
            {
                cumulativeIdeaScore += eachScore.totalScore;
                idea.cumulativeIdeaAverage = cumulativeIdeaScore / idea.ideaScores.Count;
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