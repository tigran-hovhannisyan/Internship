using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = Time.Input();
            Time swap = Time.Input();

            time = time.Swap(swap);

            time.Print();
            Console.ReadLine();
        }

        public struct Time
        {
            public int Hour { get; set; }
            public int Minutes { get; set; }

            public Time(int hour, int minute)
            {
                this.Hour = hour;
                this.Minutes = minute;
            }

            public Time(Time time)
            {
                this = time;
            }

            public Time Swap(Time time)
            {
                Time temp;
                temp = this;
                this = time;
                return this;
            }

            static public Time Input()
            {
                int h, m;
                do
                {
                    Console.Write("Input hours in 24hour format: ");
                } while (!int.TryParse(Console.ReadLine(), out h) || h < 0 || h > 23);
                do
                {
                    Console.Write("Input minutes: ");
                } while (!int.TryParse(Console.ReadLine(), out m) || m < 0 || m > 59);

                return new Time(h, m);
            }

            public void Print()
            {
                if(this.Hour < 10)
                {
                    Console.Write($"0{this.Hour}");
                }
                else
                {
                    Console.Write(this.Hour);
                }
                Console.Write(" : ");

                if (this.Minutes < 10)
                {
                    Console.Write($"0{this.Minutes}");
                }
                else
                {
                    Console.Write(this.Minutes);
                }
            }
        }

    }
}
