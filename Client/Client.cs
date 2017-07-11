using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contract;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            IContract proxy = ChannelFactory<IContract>.CreateChannel(new BasicHttpBinding(),
                new EndpointAddress("http://localhost:150/IContract"));

            using (proxy as IDisposable)
            {
                string nickname = "Alex";

                Console.WriteLine("Введите команду:");
                Label:
                string x = Console.ReadLine();
                // Return list of users
                if (x == "GET/Services/TestService/Users")
                {
                    string result = proxy.GetAll(x);
                    Console.WriteLine(result);
                    Console.ReadKey();
                }
                // Get user information
                else if (x == "GET/Services/TestService/Users/" + nickname)
                {
                    string result1 = proxy.GetOne(x);
                    Console.WriteLine(result1);
                    Console.ReadKey();
                }
                // Add user
                else if (x == "POST/Services/TestService/Users/")
                {
                    string s = x.Substring(32);
                    string result2 = proxy.AddUser(s);
                    Console.WriteLine(result2);
                    Console.ReadKey();
                }
                // Delete user
                else if(x == "DELETE/Services/TestService/Users/" + nickname)
                {
                    string result3 = proxy.DelUser(x);
                    Console.WriteLine(result3);
                    Console.ReadKey();
                }
                // Update user
                else if (x == "PUT/Services/TestService/Users/" + nickname)
                {
                    string result4 = proxy.PutUser(x);
                    Console.WriteLine(result4);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid command! Try again.");
                    goto Label;
                }
            }
            }
        }
    }
