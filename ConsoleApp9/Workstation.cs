using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Workstation : Computer, IConnectable
    {
        public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os) { }

        public void ConnectTo(IConnectable device)
        {
            Console.WriteLine($"Workstation {IPAddress} connected to {device.GetType().Name} with IP: {((Computer)device).IPAddress}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"Workstation {IPAddress} disconnected");
        }

        public void TransmitData(string data)
        {
            Console.WriteLine($"Workstation {IPAddress} transmitted data: {data}");
        }
    }
}
