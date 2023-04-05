using System.ComponentModel;
using System.Runtime.InteropServices;

namespace IdeasTracker
{

    public class IdeasPool : IAddIdeas, IUniqueId
    {
        public Guid id { get; set; }
        public DateTime timeframe;
        public string priority;
        public List<Idea>ideasScores = new List<Idea>();
        public List<string> reviewedIdeas;
        public List<string> acceptedIdeas = new List<string>();
        public List<string> rejectedIdeas;



        public IdeasPool(DateTime date, string priority)
        {

            this.timeframe = DateTime.Now;
            this.priority = priority;    
        }

        public double AverageIdeaScore()
        {
            int total = 0;
            double average = 0;
            foreach( int score in ideasScores)
            {
                total += score;

                average = total/ ideasScores.Count;
            }
            return average;
        }

        public List<Idea> AddIdea(Idea idea)
        {
            if (AverageIdeaScore >= 12)
            {
                acceptedIdeas.Add(idea);
                return acceptedIdeas;
            }
            if(AverageIdeaScore > 1 && AverageIdeaScore < 12)
            {
                rejectedIdeas.Add(idea);
                return rejectedIdeas;
            }

            reviewedIdeas.Add(idea);
            return reviewedIdeas;
        }

    }


}