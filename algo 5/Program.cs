
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            Console.WriteLine("Ingrese un número Entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero2 = int.Parse(Console.ReadLine());
            if (numero1 == numero2)
            {
                resultado = numero1 + numero2;
                Console.WriteLine("El resultados es: " + resultado);
                Console.ReadLine();
            }
            else
            {
                resultado = numero1 - numero2;
                Console.WriteLine("El resultados es: " + resultado);
                Console.ReadLine();
            }
        }
    }
}
