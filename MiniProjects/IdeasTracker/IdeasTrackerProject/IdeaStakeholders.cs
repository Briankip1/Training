using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasTracker
{
    public class IdeaStakeholders
    {
        public string areaOfExpertise;
        public bool availability;
        public int yearsOfExperience;

        public IdeaStakeholders(string areaofexpertise, bool availability, int yearsofexperience)
        {
            this.areaOfExpertise = areaofexpertise;
            this.availability = availability;
            this.yearsOfExperience = yearsofexperience;  
        }
    }
}
