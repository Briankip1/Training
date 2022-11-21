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
        public int distanceCovered;

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
            battery -= batteryDrain;
        }

        public int DistanceDriven()
        {
            distanceCovered = metersDriven * battery/batteryDrain;
            return distanceCovered;
        }
        public bool BatteryDrained()
        {
            if(battery == 0)
            {
                Console.WriteLine("Battery is done");
                return true;
            }
            else
            {
                Console.WriteLine($"battery {battery}%");
                return false;
            }
        }

        public static RemoteControlCar Nitro() 
        {
            return new RemoteControlCar(50, 4);
        }
    }
}
