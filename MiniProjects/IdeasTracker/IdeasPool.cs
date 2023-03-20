using System.ComponentModel;

namespace IdeasTracker
{
    public class Idea
    {
        public string Title;
        public string Description;
        public string IdeaSponsor;
        public DateTime date;
        public List<string> PoolOfIdeas;

        List<string> categories = new List<string>() { "ArtsandEntertainment", "Marketing", "ContentMarketing", "Design", "FoodAndHospitality", "Writing", "SportAndFitness", "Technology" };



        public Idea(DateTime date, string description, string ideasponsor, string title)
        {

            this.date = DateTime.Now;
            this.Description= description;
            this.IdeaSponsor = ideasponsor;
            this.Title = title;
            
        }


        public void IdeaEntry()
        {
            Console.WriteLine($" Enter Idea Title: {Title}");
            Console.WriteLine($" Enter Idea Description: {Description}");
            Console.WriteLine($" Enter Idea Sponsor: {IdeaSponsor}");
            Console.WriteLine($" Enter Idea Date: {date}");

  

        }

        public string CategorizeIdea()
        {
            Console.WriteLine("Choose category based on the list below:");
            Console.WriteLine("ArtsandEntertainment\n", "Marketing\n", "ContentMarketing\n", "Design\n", "FoodAndHospitality\n", "Writing\n", "SportAndFitness\n", "Technology");
            var ?userInput = Console.ReadLine();

            if(categories.Contains(userInput))
            {
                IdeaEntry();
                return $"Idea category: {userInput}";
            }
            else
            {
                Console.WriteLine("Invalid category entered");

            }
            return userInput;


        }




    }

        
  
}