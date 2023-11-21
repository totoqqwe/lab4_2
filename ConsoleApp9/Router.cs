using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Router : Computer, IConnectable
    {
        public Router(string ipAddress, int power, string os) : base(ipAddress, power, os) { }

        public void ConnectTo(IConnectable device)
        {
            Console.WriteLine($"Router {IPAddress} connected to {device.GetType().Name} with IP: {((Computer)device).IPAddress}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"Router {IPAddress} disconnected");
        }

        public void TransmitData(string data)
        {
            Console.WriteLine($"Router {IPAddress} transmitted data: {data}");
        }
    }
}
