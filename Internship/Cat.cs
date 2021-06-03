using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class Cat
    {
        string Name;
        double Age;
        string Color;
        bool isMale;

        public Cat(string name)
        {
            this.Name = name;
        }

        public Cat(string name, double age) : this(name)
        {
            this.Age = age;
        }

        public Cat(string name, double age, string color) : this(name, age)
        {
            this.Color = color;
        }

        public Cat(string name, double age, string color, bool isMale) : this(name, age, color)
        {
            this.isMale = isMale;
        }
    }
}
