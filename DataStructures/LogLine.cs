using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class logLine
    {
        int counter;

        public logLine(int counter)
        {
            this.counter = counter;
        }

       public string getIp()
        {
            return "ip-" + counter;
        }
    }
}
