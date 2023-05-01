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
        public DateTime estimatedProjectTimeline;
        public double estimatedCost;
        public string task;
        public enum projectState
        {
            Start,
            Inprogress,
            Done
        }
        public List<Professional> assignedprofessionals= new List<Professional>();
        public Project(double cost, string projectTask)
        {
            estimatedCost = cost;
            task = projectTask;
            estimatedProjectTimeline = DateTime.Now;
        }

        public string ProjectTracking()
        {
            return null;

        }





    }
}
