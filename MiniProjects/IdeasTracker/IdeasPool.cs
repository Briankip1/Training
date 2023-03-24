using System.ComponentModel;

namespace IdeasTracker
{
    public class IdeaPool
    {

        public DateTime timeframe;
        public string priority;
        public List<string> enteredIdeas = new List<string>();
        public List<string> reviewedIdeas;
        public List<string> acceptedIdeas;
        public List<string> rejectedIdeas;
        List<string> category = new List<string>() { "ArtsandEntertainment", "Marketing", "ContentMarketing", "Design", "FoodAndHospitality", "Writing", "SportAndFitness", "Technology" };



        public IdeaPool(DateTime date, string priority)
        {

            this.timeframe = DateTime.Date.AddDays;
            this.priority = priority;    
        }


        public void IdeaEntry(string title, string description, string ideaSponsor, DateTime date)
        {
            Console.WriteLine($" Enter Idea Title: {title}");
            Console.WriteLine($" Enter Idea Description: {description}");
            Console.WriteLine($" Enter Idea Sponsor: {ideaSponsor}");
            Console.WriteLine($" Enter Idea Date: {date}");

            enteredIdeas.AddRange(title,description,ideaSponsor,date );

        }

        public string CategorizeEnteredIdea()
        {
            Console.WriteLine("Choose category based on the list below:");
            Console.WriteLine("ArtsandEntertainment\n", "Marketing\n", "ContentMarketing\n", "Design\n", "FoodAndHospitality\n", "Writing\n", "SportAndFitness\n", "Technology");
            string ?userInput = Console.ReadLine();

            if(category.Contains(userInput))
            {
                enteredIdeas.Add(userInput);
            }
            else
            {
                Console.WriteLine("Invalid category entered");

            }
            return userInput;


        }

    }

        
  
}