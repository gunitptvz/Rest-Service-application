using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Rest_Service
{
    class Server
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";

            ServiceHost host = new ServiceHost(typeof(MyService));
            host.AddServiceEndpoint(typeof (IContract), new BasicHttpBinding(), new Uri("http://localhost:150/IContract"));

            host.Open();
            Console.WriteLine("The host opened!");

            Console.ReadKey();
            host.Close();
        }
    }
}
