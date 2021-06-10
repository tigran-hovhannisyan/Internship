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
            Reader reader = new Reader();
            reader.FName = "Tigran";
            reader.LName = "Hovhannisyan";
            reader.TakeBook(4);
            reader.TakeBook(new Book { Author = "Jiulle Verne", Name = "20000 llos under the water" });

            Console.ReadLine();
        }

        static public int ArrayLengthInput(string parameterName = "length")
        {
            int n;
            string input;
            do
            {
                Console.Write("Input array " + parameterName + ": ");
                input = Console.ReadLine();
                if (!int.TryParse(input, out n) || int.Parse(input) < 1)
                {
                    Console.WriteLine("Not valid " + parameterName + ". Try again.");
                }
            } while (!int.TryParse(input, out n) || int.Parse(input) < 1);
            return n;
        }

        static public int[] ArrayGetter()
        {
            int length = ArrayLengthInput();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"arr[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static public int[,] TwoDimensionalArrayGetter()
        {
            int h = ArrayLengthInput("height");
            int w = ArrayLengthInput("width");

            int[,] arr = new int[h, w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr;
        }

        static public int[][] JaggedArrayGetter()
        {
            int n = ArrayLengthInput();
            int temp;
            int[][] jagged = new int[n][];
            for (int i = 0; i < jagged.Length; i++)
            {
                temp = ArrayLengthInput($"jagged[{i}] length");
                jagged[i] = new int[temp];
                for (int j = 0; j < temp; j++)
                {
                    Console.Write($"jagged[{i}][{j}] = ");
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return jagged;
        }
        public static int DividedTo5Jagged(int[][] jagged)
        {
            int count = 0;
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j] % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static public int DividedTo5TwoDimensional(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static public int[] EvenNumbersFromTwoDimensional(int[,] arr)
        {
            int[] evens = new int[arr.Length];
            int evensIndex = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        evens[evensIndex++] = arr[i, j];
                    }
                }
            }
            return evens;
        }

        static public int[] EvenNumbersFromJagged(int[][] arr)
        {
            int jaggedCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                jaggedCount += arr[i].Length;
            }
            int[] evens = new int[jaggedCount];
            int evensIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        evens[evensIndex++] = arr[i][j];
                    }
                }
            }
            return evens;
        }

        static public int TwoDimensionalMaximum(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }

        static public int JaggedMaximum(int[][] arr)
        {
            int max = arr[0][0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
            }
            return max;
        }

        public static int MaxManual(params int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int[] SortManual(params int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

    }
}
