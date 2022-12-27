using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordsManagementProject
{
    public class DataBank
    {
        public string Name;
        public string uniqueID;
        public List<HealthFacility> facilityList;

        public DataBank(string name, string uniqueID, List<HealthFacility> healthFacilities) 
        {
            this.Name = name;
            this.uniqueID = uniqueID;
            this.facilityList = healthFacilities;
        }

        //public List<HealthFacility> RetrieveMasterList()
        //{
            //Allows retrieval of patient and healthprovider records
        //}

          //public string AunthenticateAccess()
       // {
            //Authenticate records retrieval
            // UniqueIDs should match those in the system

       // }

        public void Store()
        {
            //store new list of patient and health provider records
            facilityList = new List<HealthFacility>();
        }
    }    

}
