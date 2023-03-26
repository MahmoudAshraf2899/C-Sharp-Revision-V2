using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Services
{
    internal class Command
    {
        private readonly DateTime _createdAt;
        private readonly string _url;

        public Command( string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }
        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] - [{this._url}]";
        }
    }
}
