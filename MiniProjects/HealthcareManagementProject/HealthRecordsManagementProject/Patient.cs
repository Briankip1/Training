using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    
    public record Patient ( string firstName, string lastName, string emailAddress, string phoneNumber, string uniquePatientID, string homeAddress);
        
}
