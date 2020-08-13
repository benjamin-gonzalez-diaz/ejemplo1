using System;

namespace aprender_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string instructions = "ingrese un numero";
            Console.WriteLine(instructions); // print("...")
            int number = Int32.Parse(Console.ReadLine()); // number = int(input(""))
            Console.WriteLine(number); // print(number)
            PrintNumbers(number); // PascalCase para el nombre
            Console.ReadKey();
        }

        public static void PrintNumbers(int number)
        {

            for (int i = 1; i <= number; i++)
            {  // (i++ = i += 1 
                bool xd = IsEven(i);
                if (xd)
                {
                    Console.WriteLine(i + "par");
                }
                else
                {
                    Console.WriteLine(i + "no par");
                }
            }    
        }

        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
