using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр1
{
    internal class Client:user
    {
        public Client(string name, string login, string password) : base(name, login, password)
        { }
        public void TakeResult(Request request)
        {
            
        }
    }

}

