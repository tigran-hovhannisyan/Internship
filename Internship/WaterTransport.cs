using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class WaterTransport : Transport
    {
        private string Material { get; set; }

        public override void Go()
        {
            Console.WriteLine("Water Transport started going.");
        }

        public override void Stop()
        {
            Console.WriteLine("Water Transport stopped.");
        }
        protected void SwimmingSpeed() { }
    }
}
