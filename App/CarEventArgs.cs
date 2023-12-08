using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CarEventArgs : EventArgs
    {
        public string EventMessage { get; }
        public CarEventArgs(string eventMessage)
        {
            EventMessage = eventMessage;
        }
    }
}
