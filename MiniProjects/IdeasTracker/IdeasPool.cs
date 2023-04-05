﻿using System.ComponentModel;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IdeasTracker
{

    public class IdeasPool : IUniqueId
    {
        public Guid id { get; set; }
        public DateTime timeframe;
        public string priority;
        public List<Idea>ideasScores = new List<Idea>();
        public List<string> enteredIdeas = new List<string>();
        public List<Idea> reviewedIdeas;
        public List<string> acceptedIdeas = new List<string>();
        public List<string> rejectedIdeas;
        List<string> category = new List<string>() { "ArtsandEntertainment", "Marketing", "ContentMarketing", "Design", "FoodAndHospitality", "Writing", "SportAndFitness", "Technology" };




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


        public string IdeaEntry(Idea idea)
        {
            Console.WriteLine("Enter title name:");
            idea.title = Console.ReadLine();
            Console.WriteLine("Enter idea description:");
            idea.description = Console.ReadLine();
            Console.WriteLine("Enter idea sponsor");
            idea.sponsor = Console.ReadLine();
            Console.WriteLine("Enter the date:");
            idea.date = DateTime.Now;

            return $" {idea.title} {idea.description} {idea.sponsor} {idea.date}";
        }

        public string CheckAndAddIdeaCategory()
        {
            var someIdea = new Idea();
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
                return $"{IdeaEntry(someIdea)} : {userInput}";
            }
            else
            {
                return $"{IdeaEntry(someIdea)} : Other";
            }
        }

        public List<Idea> AddIdea(Idea idea)
        {
            if (AverageIdeaScore() >= 12)
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