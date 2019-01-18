using Magic8BallWCFServiceHTTP;
using System;
using System.ServiceModel;

namespace Magic8BallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(Magic8BallService)))
            {
                serviceHost.Open();
                DisplayHostInfo(serviceHost);
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }

        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine("-- Host Info --");

            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine("Address: {0}", se.Address);
                Console.WriteLine("Binding: {0}", se.Binding.Name);
                Console.WriteLine("Contract: {0}", se.Contract.Name);
            }
            Console.WriteLine("-------------------------------");
        }
    }
}
