using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal interface IConnectable
    {
        void ConnectTo(IConnectable device);
        void Disconnect();
        void TransmitData(string data);
    }
}
