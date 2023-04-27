using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр1
{
    internal class LabourSystem : Request
    {
        public LabourSystem(Client requester, string job, int payment, int hoursPerWeek, int type, string name, string login, string password) : base(requester, job, payment, hoursPerWeek, type, name, login, password)
        { }
        public List<user> user { get; set; }
        public List<WorkerRequest> workerRequests { get; set; }
        public List<EmployerRequest> employerRequests { get; set; }

        public user currentUser { get; set; }

        public void addUser(string name, string login, string password, string repuation, int type)
        {
            user newUser = new user(name, login, password, repuation, type);
            user.Add(newUser);
        }
    
        public user findUser(string login, string password)
        {
            foreach (user u in user)
            {
                if (u.login == login && u.password == password)
                {
                    return u;
                }
            }
            return null;
        }


        public void save()
        {
            
        }

        public void load()
        {
         
        }

        public void crearWorkerRequests(Client worker)
        {
       
        }

        public void processRequests()
        {
           
        }
     }

       
    
}

