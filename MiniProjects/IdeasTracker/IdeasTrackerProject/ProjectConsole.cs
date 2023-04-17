using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasTracker
{
    public class ProjectConsole: IConsole
    {
        public void WriteLine(string message) 
        {
            Console.WriteLine(message);

        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }

    }
}
