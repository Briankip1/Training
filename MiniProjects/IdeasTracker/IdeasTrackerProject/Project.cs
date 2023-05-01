using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IdeasTracker
{
    

    public class Project
    {
        public int estimatedProjectTimeline;
        public double estimatedCost;
        public string task;
        public enum projectState
        {
            Start,
            Inprogress,
            Done
        }
        public List<Professional> assignedprofessionals= new List<Professional>();
        public Project(double cost, string projectTask, int timeline)
        {
            estimatedCost = cost;
            task = projectTask;
            estimatedProjectTimeline = timeline;
        }

        public string ProjectTimeTracking()
        {
            var projectStarted = projectState.Start;
            for (int i = estimatedProjectTimeline; i > 0; i--)
            {
                Console.WriteLine("Send daily task report");
            }
            
            if(estimatedProjectTimeline > 0)
            {
                Console.WriteLine("The task is late");
            }
            return null;
        }

        public double ProjectCost()
        {
            return estimatedCost;

        }

        public string taskProgress()
        {
            return null;
        }




    }
}
