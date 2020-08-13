using System;


namespace algo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many integers do you want to print? ");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write("What is the first integer you want printed? ");
            int start = Int32.Parse(Console.ReadLine());
            Console.ReadKey();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(start + i);
                Console.ReadKey();
            }
        }
    }
}
