using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Services
{
    internal class Update
    {
        private int no;
        private string title;

        public Update(int no, string title)
        {
            this.no = no;
            this.title = title;
        }
        public override string ToString()
        {
            return $"{no} - {title}"; //Ex : 1 - Update
        }
    }
}
