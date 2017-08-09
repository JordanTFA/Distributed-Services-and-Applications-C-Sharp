using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create address
            Uri baseAddress = new Uri("http://localhost:8000/EdinburghNapier/HelloWorldService");

            // Creare service host to host the HelloWorldService
            ServiceHost host = new ServiceHost(typeof(HelloWorldService), baseAddress);

            try
            {
                // Add a service and point to the host of the interface type.
                // We are hosting as a web service on http binding
                // So we use WSHttpBinding

                host.AddServiceEndpoint(typeof(IHelloWorldService), new WSHttpBinding(), "HelloWorldService");

                // Add the ability to get the web service description from the host
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                // Now host the service
                host.Open();

                // Print message that service is running and wait for user to press return to quit
                Console.WriteLine("The service is ready!");
                Console.WriteLine("Press <RETURN> to exit");
                Console.WriteLine();
                Console.ReadLine();

                // Close the host
                host.Close(); 
            }
            catch (CommunicationException ce)
            {
                // Something bad happened
                Console.WriteLine("Exception occured: {0}", ce.Message);
                host.Abort();
            }
        }
    }
}
