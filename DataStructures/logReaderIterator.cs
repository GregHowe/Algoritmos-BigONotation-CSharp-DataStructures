using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class logReaderIterator : IEnumerator<logLine>
    {
        private int counter = 0;
        private int sizeLogLines;
        private int sizeUniqueIps;
        private logLine _current;

        public logReaderIterator(int sizeLogLines, int sizeUniqueIps)
        {
            this.sizeLogLines = sizeLogLines;
            this.sizeUniqueIps = sizeUniqueIps;
        }

        public logLine Current => _current;

        object IEnumerator.Current => Current;

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (this.hasNext())
            {
                this.counter++;
                _current = new logLine(this.counter % this.sizeUniqueIps);
                return true;
            }
            return false;
        }

        public bool hasNext()
        {
            return this.counter < this.sizeLogLines;
        }
        
        public void Dispose()
        {
            _current = null;
        }


    }
}
