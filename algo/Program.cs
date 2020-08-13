using System;

namespace ProyectoPrueba
{
    class MainClass
    {
        public static bool IsEven(int number)
        {
            if (number % 2 == 0) // if number % 2 == 0:
            {
                return true;
            }
            return false;
            // return number % 2 == 0;
        }
        public static void Main(string[] args) // def main(args)
        {
            string instructions = "Ingresa un número";
            Console.WriteLine(instructions); // print("...")
            int number = Int32.Parse(Console.ReadLine()); // number = int(input(""))
            Console.WriteLine(number); // print(number)
            PrintNumbersUntil(number); // PascalCase para el nombre
            Console.ReadKey(); // Para que el terminal no se cierre al final y poder leer lo  que sale en pantalla
                               // Se va a cerrar cuando presionen una tecla.
        }

        public static void PrintNumbersUntil(int number)
        {
            for (int i = 0; i < number; i++){ // i += 1
                bool even = IsEven(i);
                if (even) {
                    Console.WriteLine(i + " par");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

      
    }
}