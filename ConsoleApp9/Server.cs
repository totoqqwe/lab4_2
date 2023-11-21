using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Server : Computer, IConnectable
    {
        public Server(string ipAddress, int power, string os) : base(ipAddress, power, os) { }

        public void ConnectTo(IConnectable device)
        {
            Console.WriteLine($"Server {IPAddress} connected to {device.GetType().Name} with IP: {((Computer)device).IPAddress}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"Server {IPAddress} disconnected");
        }

        public void TransmitData(string data)
        {
            Console.WriteLine($"Server {IPAddress} transmitted data: {data}");
        }
    }
}
