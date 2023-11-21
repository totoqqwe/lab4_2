using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Network
    {
        private List<IConnectable> devices;

        public Network()
        {
            devices = new List<IConnectable>();
        }

        public void AddDevice(IConnectable device)
        {
            devices.Add(device);
        }

        public void SimulateNetworkActivity()
        {
            Random random = new Random();

            foreach (var device in devices)
            {
                if (random.Next(2) == 0)
                {
                    IConnectable targetDevice = devices[random.Next(devices.Count)];
                    device.ConnectTo(targetDevice);
                }
                else
                {
                    device.Disconnect();
                }

                IConnectable destinationDevice = devices[random.Next(devices.Count)];
                device.TransmitData($"Hello from {device.GetType().Name} to {destinationDevice.GetType().Name}");
            }
        }
    }
}
