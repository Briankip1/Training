using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasTracker
{
    public class TestConsole : IConsole
    {

        public void WriteLine(string message)
        {
        }

        public string ReadLine()
        {
            return "0";
        }

    }

}
