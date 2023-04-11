using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IdeasTracker
{
    interface IIdeaentry
    {
        Idea IdeaEntry(Idea idea);
        void IdeaEntryQuiz();
    }
    public class IdeasPool : IUniqueId, IIdeaentry
    {
        public Guid id { get; set; }
        public DateTime timeframe;
        public string priority;
        public List<int> ideasScores = new List<int>();
        public List<Tuple<Idea,string>>enteredIdeas = new();
        public List<Idea> reviewedIdeas = new List<Idea>();
        public List<Idea> acceptedIdeas = new List<Idea>();
        public List<Idea> rejectedIdeas = new List<Idea>();
        List<string> category = new List<string>() { "ArtsandEntertainment", "Marketing", "ContentMarketing", "Design", "FoodAndHospitality", "Writing", "SportAndFitness", "Technology" };


        public IdeasPool(DateTime date, string priority)
        {

            this.timeframe = DateTime.Now;
            this.priority = priority;
        }

        public void IdeaEntryQuiz()
        {
            Console.WriteLine("Enter title name:");
            Console.WriteLine("Enter idea description:");
            Console.WriteLine("Enter idea sponsor");
            Console.WriteLine("Enter the date:");
        }
        public Idea IdeaEntry(Idea idea)
        {
            idea.title = Console.ReadLine();
            idea.description = Console.ReadLine();
            idea.sponsor = Console.ReadLine();
            idea.date = DateTime.Now;
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

        public void AddNewIdeatoEnteredIdeas()
        {
            enteredIdeas.Add(CheckAndAddIdeaCategory(new Idea()));
        }

        public double AverageIdeaScore(Idea idea)
        {

            foreach (int score in ideasScores)
            {
                idea.cumulativeIdeaScore += score;

                idea.cumulativeIdeaAverage = idea.cumulativeIdeaScore / ideasScores.Count;
            }
            return idea.cumulativeIdeaAverage;
        }

        public List<Idea> ClassifyIdea(Idea idea)
        {
            if (AverageIdeaScore(idea) >= 12)
            {
                acceptedIdeas.Add(idea);
                return acceptedIdeas;
            }
            if (AverageIdeaScore(idea) < 12)
            {
                rejectedIdeas.Add(idea);
                return rejectedIdeas;
            }

            reviewedIdeas.Add(idea);
            return reviewedIdeas;
        }

        
    }
}