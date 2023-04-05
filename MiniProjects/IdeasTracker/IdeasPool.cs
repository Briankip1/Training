using System.ComponentModel;

namespace IdeasTracker
{

    public class IdeasPool : IAddIdeas
    {

        public DateTime timeframe;
        public string priority;
        public List<Idea>ideasUnderReview = new List<Idea>();
        public List<string> reviewedIdeas;
        public List<string> acceptedIdeas = new List<string>();
        public List<string> rejectedIdeas;



        public IdeasPool(DateTime date, string priority)
        {

            this.timeframe = DateTime.Now;
            this.priority = priority;    
        }

    }

        
  
}