using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create binding for web service - We use WebHttpHinding
            // this time to indicate that we are exposing a standard
            // web interface

            WebHttpBinding binding = new WebHttpBinding();

            // Create the service host. This is the same as previous,
            // although we use a WebServiceHost this time rather
            // than a ServiceHost

            StudentService service = new StudentService();

            WebServiceHost host = new WebServiceHost(service);

            // Add a service endpoint as before. Not the URL used

            host.AddServiceEndpoint(typeof(IStudentService),
                binding, "http://localhost:8000/students");

            // Open the host
            host.Open();

            // Display message and wait for use input to exit
            Console.WriteLine("Web Service Running");
            Console.WriteLine("Press <RETURN> to end service");
            Console.ReadLine();
        }
    }
}
