// CHRISTOPHER D'ENTREMONT 
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2SELFHOST / 'PROGRAM' CLASS
// OPENS SERVICE HOST TERMINAL - TYPE 'SERVICE1'

using System;
using System.ServiceModel;

namespace Property2Selfhost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ServiceHost 
            using (ServiceHost serviceHost = new ServiceHost(typeof(Service1)))
            {
                // Open the ServiceHost to create listeners
                // and start listening for messages.
                serviceHost.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }

        }
    }
}
