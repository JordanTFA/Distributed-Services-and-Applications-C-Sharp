using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    [ServiceContract(Namespace="http://www.napier.ac.uk")]
    interface IHelloWorldService
    {
        [OperationContract]
        string HelloWorld();
    }
}
