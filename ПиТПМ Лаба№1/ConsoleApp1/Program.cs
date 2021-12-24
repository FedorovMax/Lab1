using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine("Так нельзя!");
                }
                else
                {
                    Console.Write("{0} = 1", num);

                    for (int i = 0; num % 2 == 0; num /= 2)
                    {
                        Console.Write(" * {0}", 2);
                    }
                    for (int i = 3; i <= num;)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(" * {0}", i);
                            num /= i;
                        }
                        else
                        {
                            i += 2;
                        }
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
   
