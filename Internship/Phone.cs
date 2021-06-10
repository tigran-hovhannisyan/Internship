using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class Phone
    {
        private string Number { get; set; }
        private string Model { get; set; }
        private double Weight { get; set; }
        public Phone()
        {

        }

        public Phone(string number, string model)
        {
            Number = number;
            Model = model;
        }

        public Phone(string number, string model, double weight) : this(number, model)
        {
            Weight = weight;
        }

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"{callerName} is calling...");
        }

        public void ReceiveCall(string callerName, string callerNumber)
        {
            ReceiveCall(callerName);
            Console.WriteLine(callerNumber);
        }

        public void SendMessage(params string[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
