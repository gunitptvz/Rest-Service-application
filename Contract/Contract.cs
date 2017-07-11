using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contract
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        string GetAll(string a);

        [OperationContract]
        string GetOne(string a);

        [OperationContract]
        string AddUser(string a);

        [OperationContract]
        string DelUser(string a);

        [OperationContract]
        string PutUser(string a);
    }

    class Contract
    {
        static void Main(string[] args)
        {

        }
    }
}
