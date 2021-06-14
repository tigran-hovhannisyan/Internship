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
            Coordinate M = Coordinate.Input();
            Coordinate N = new Coordinate(M);

            Coordinate.CoordinateAdd(M, N).Print();
            Coordinate.CoordinateDiv(M, N).Print();
            Coordinate.CoordinateMultiple(M, N).Print();
            Coordinate.CoordinateSub(M, N).Print();
        }
    }

    public struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Coordinate(Coordinate coordinate)
        {
            this = coordinate;
        }

        public void Print()
        {
            Console.WriteLine($"X: {X}                  Y: {Y}");
        }
        
        static public Coordinate Input()
        {
            int x, y;
            do
            {
                Console.Write("Input X: ");
            } while (!int.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.Write("Input Y: ");
            } while (!int.TryParse(Console.ReadLine(), out y));

            return new Coordinate(x, y);
        }

        static public Coordinate CoordinateAdd(Coordinate coord1, Coordinate coord2)
        {
            return new Coordinate(coord1.X + coord2.X, coord1.Y + coord2.Y);
        }
        
        static public Coordinate CoordinateSub(Coordinate coord1, Coordinate coord2)
        {
            return new Coordinate(coord1.X - coord2.X, coord1.Y - coord2.Y);
        }

        static public Coordinate CoordinateDiv(Coordinate coord1, Coordinate coord2)
        {
            try
            {
                return new Coordinate(coord1.X / coord2.X, coord1.Y / coord2.Y);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw new DivideByZeroException();
            }
        }

        static public Coordinate CoordinateMultiple(Coordinate coord1, Coordinate coord2)
        {
            return new Coordinate(coord1.X * coord2.X, coord1.Y * coord2.Y);
        }

    }
}
