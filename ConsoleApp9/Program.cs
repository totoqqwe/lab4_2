using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("192.168.1.1", 1000, "Windows Server");
            Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10");
            Router router = new Router("192.168.1.3", 800, "RouterOS");

            Network network = new Network();
            network.AddDevice(server);
            network.AddDevice(workstation);
            network.AddDevice(router);

            for (int i = 0; i < 5; i++)
            {
                network.SimulateNetworkActivity();
                Console.WriteLine();
            }
        }
    }
}
