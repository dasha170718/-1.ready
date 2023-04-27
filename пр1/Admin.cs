using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр1
{
    internal class Admin:user
    {
        public Admin(string name, string login, string password)
            : base(name, login, password) { }

        public override bool Enter(string login, string password)
        {
            if (Login == "admin" && Password == "admin123")
            {
                return true;
            }
            return base.Enter(login, password);
        }
    }
}
