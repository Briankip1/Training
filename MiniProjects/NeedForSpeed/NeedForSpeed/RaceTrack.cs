using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceTrack
    {
        
        public int trackDistance;

        public RaceTrack(int distance)
        {
            this.trackDistance = distance;
           
        }

        public bool TryFinishTrack(RemoteControlCar car1)
        {
            if(car1.battery != 0 && car1.distanceCovered >= trackDistance)
            {
                Console.WriteLine(" Yes, your car that finish the car");
                return true;
            }
            else
            {
                Console.WriteLine("Oops, it seems your car cannot complete the race, upgrade");
                return false;
            }
        }
    }
}
