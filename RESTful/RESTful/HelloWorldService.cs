using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful
{
    [ServiceContract]
    class HelloWorldService
    {
        [OperationContract]
        [WebGet(UriTemplate = "")]
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
