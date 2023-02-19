using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class HealthFacility
    {
        public string Name;
        public Guid UniqueID;
        


        public HealthFacility(string name)
        {
            Name = name;
            UniqueID = Guid.NewGuid();
        }
       
    }
}
