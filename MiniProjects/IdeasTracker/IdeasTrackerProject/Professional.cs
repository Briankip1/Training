using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasTracker
{
    public class Professional: IdeaStakeholders, IUniqueId
    {
        public Guid id { get; set; }
        public List<Idea> assignedProjects = new List<Idea>();

        public Professional(string areaOfExpertise, bool availability, int yearsOfExperience): base(areaOfExpertise, availability,yearsOfExperience)
        {
        }

        public void UpdateOnProgress()
        {

        }
    }
}
