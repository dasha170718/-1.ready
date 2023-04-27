using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace пр1
{
    internal class Request:Client
    {
        private readonly Client requester;
        private readonly string job;
        private readonly int payment;
        private readonly int hoursPerWeek;
        private readonly int type;

        public Request( Client requester, string job, int payment, int hoursPerWeek, int type, string name, string login, string password) : base(name, login, password)
        {
            this.requester = requester;
            this.job = job;
            this.payment = payment;
            this.hoursPerWeek = hoursPerWeek;
            this.type = type;
            
        }

        public Client GetRequester()
        {
            return requester;
        }

        public string GetJob()
        {
            return job;
        }

        public int GetPayment()
        {
            return payment;
        }

        public int GetHoursPerWeek()
        {
            return hoursPerWeek;
        }

        public int GetType()
        {
            return type;
        }
    }
}

