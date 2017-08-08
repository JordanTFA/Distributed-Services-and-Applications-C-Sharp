using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    class HelloWorldService : IHelloWorldService
    {
        public string HelloWorld(){
            return "Hello World";
        }
    }
}
