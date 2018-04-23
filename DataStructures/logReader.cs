using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class logReader: IEnumerable<logLine>
    {
        private int sizeLogLines;
        private int sizeUniqueIps;
        private ICollection<string> uniqueIps;

        public logReader(int sizeLogLines, int sizeUniqueIps)
        {
            this.sizeLogLines = sizeLogLines;
            this.sizeUniqueIps = sizeUniqueIps;
            this.uniqueIps = new HashSet<string>(); 
        }

        public IEnumerator<logLine> GetEnumerator()
        {
            return new logReaderIterator(this.sizeLogLines, this.sizeUniqueIps);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new logReaderIterator(this.sizeLogLines, this.sizeUniqueIps);
        }


        public int readAllLogs()
        {
            int sizeLogLines = 0;
            foreach (logLine line in this)
            {
                string ip = line.getIp();
                sizeLogLines++;
            }
            return sizeLogLines;
        }

        public int getSizeUniqueIps()
        {
            foreach (logLine line in this)
            {
                string ip = line.getIp();
                if (!this.uniqueIps.Contains(ip))
                {
                    this.uniqueIps.Add(ip);
                }
            }
            return this.uniqueIps.Count;
        }



    }
}
