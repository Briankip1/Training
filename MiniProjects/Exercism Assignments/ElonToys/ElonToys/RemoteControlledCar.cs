using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ElonToys
{

    public class RemoteControlledCar
    {

        
        
            public int driven = 0;
            public int battery = 100;


        public static RemoteControlledCar Buy()
        {
            RemoteControlledCar car = new RemoteControlledCar();
            return car;
        }
        

        public string DistanceDisplay()
        {
            
         return $"Driven {driven} meters";
                      
        }

        public string BatteryDisplay()
        {
          return battery == 0 ? "battery empty.." : $"battery at {battery}%"; 
        }

        public void Drive()
        {
            if(battery > 0 )
            {
                driven += 20;
                battery -= 1;
            }
             
        }             
    }
}
