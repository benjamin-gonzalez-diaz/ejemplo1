using System;

namespace ProyectoPrueba
{
    class MainClass
    {
        public static void Main(string[] args) // def main(args)
        {
            string instructions = "Ingresa un número";
            Console.WriteLine(instructions); // print("...")
            int number = Int32.Parse(Console.ReadLine()); // number = int(input(""))
            Console.WriteLine(number); // print(number)
            Console.ReadKey(); // Para que el terminal no se cierre al final y poder leer lo  que sale en pantalla
                               // Se va a cerrar cuando presionen una tecla.
        }

    }
}
