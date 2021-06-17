using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class AirTransport : Transport
    {
        private int FlyTime { get; set; }

        public sealed override void Go()
        {
            Console.WriteLine("AirTransport started going.");
        }
        public sealed override void Stop()
        {
            Console.WriteLine("AirTransport stopped.");
        }

        protected void SOS_Signal() { }
    }
}
