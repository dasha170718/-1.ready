using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр1
{
    internal class user
    {
        private string repuation;
        private int type;
        internal string login;
        internal string password;

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public user(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        public user(string name, string login, string password, string repuation, int type) : this(name, login, password)
        {
            this.repuation = repuation;
            this.type = type;
        }

        public virtual bool Enter(string login, string password)
        {
            return Login == login && Password == password;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
        
    

