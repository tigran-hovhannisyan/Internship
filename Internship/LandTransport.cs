using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class LandTransport : Transport
    {
        private int WheelCount { get; set; }

        public override void Go()
        {
            Console.WriteLine("Land Transport started going.");
        }
        public override void Stop()
        {
            Console.WriteLine("Land Transport stopped.");
        }
        public void Beep() { }
    }
}
