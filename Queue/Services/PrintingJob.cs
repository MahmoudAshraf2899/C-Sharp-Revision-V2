using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Services
{
    internal class PrintingJob
    {
        private readonly string _fileName;
        private readonly int _copies;

        public PrintingJob(string fileName, int copies)
        {
            _fileName = fileName;
            _copies = copies;
        }
        public override string ToString()
        {
            return $"{_fileName } [x] #{_copies}";//Ex : StudyFile [x]  #4
        }
    }
}
