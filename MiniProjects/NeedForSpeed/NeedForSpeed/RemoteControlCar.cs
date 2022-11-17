using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RemoteControlCar
    {
        public int speed;
        public int batteryDrain;
        public int metersDriven;
        public int battery;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
            metersDriven = 0;
            battery = 100;

        }

        public void Drive()
        {
            metersDriven += speed;
            batteryDrain -= battery;
        }

        public int DistanceDriven()
        {
            return metersDriven;
        }
        public bool BatteryDrained()
        {
            if(battery < batteryDrain)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Nitro() 
        {
            return new RemoteControlCar(50, 4);
        }
    }
}
