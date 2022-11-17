using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceTrack
    {
        public int speed;
        public int batteryDrain;
        public int metersDriven;
        public int trackDistance;

        public RaceTrack(int distance)
        {
            this.trackDistance = distance;
            this.
        }

        public bool TryFinishTrack()
        {
            if(batteryDrain > 0 && metersDriven = trackDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
