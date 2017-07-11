using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Rest_Service
{
    public class MyService : IContract
    {
        public string GetAll(string command)
        {
            return command;
        }

        public string GetOne(string command)
        {
            return command;
        }

        public string AddUser(string command)
        {
            string c1 = "Vladimir";
            string c2 = "Izotov";
            return command + c1 + c2;
        }

        public string DelUser(string command)
        {
            return command;
        }

        public string PutUser(string command)
        {
            return command + "complete";
        }
    }
}
