using System;

namespace algo3
{
    class Suma
    {
        static void Main(string[] args)
        {
            float resultado;
            string pregunta1 = "ingrese un primer numero";
            string pregunta2 = "ingrese un segundo numero";
            Console.WriteLine(pregunta1);
            int number1 = Int32.Parse(Console.ReadLine()); // number = int(input(""))
            Console.WriteLine(pregunta2);
            int number2 = Int32.Parse(Console.ReadLine()); // number = int(input(""))
            string total = "tus numeros respectivamente: ";           
            Console.WriteLine(total);
            Console.WriteLine(number1); // print(number)
            Console.WriteLine(number2); // print(number)
            string accion = "elige entre suma(0), resta(1), multiplicacion(2) o division(3)";
            Console.WriteLine(accion);
            int action = Int32.Parse(Console.ReadLine());
            Console.ReadKey();
            if (action == 0)
            {
                resultado = number1 + number2;
                Console.WriteLine("El resultados es: " + resultado);
                Console.ReadLine();
                Console.ReadKey();
            }
            if (action == 1)

            {
                resultado = number1 - number2;
                Console.WriteLine("El resultados es: " + resultado);
                Console.ReadKey();
            }
            if (action == 2)
            {
                resultado = number1 * number2;
                Console.WriteLine("El resultados es: " +  resultado);
                Console.ReadKey();
            }
            if (action == 3)
            {
                resultado = number1 / number2;
                Console.WriteLine("El resultados es: " + resultado);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ERROR, seleccione alguna opcion acorde");
                Console.ReadKey();
            }
        }
        


    }
}
