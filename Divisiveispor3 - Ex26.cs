using System;

class Program
{

    static void Main(string[] args)
    {
        int num_1, num_2;
        Console.WriteLine("Digite um número: ");
        num_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        num_2 = int.Parse(Console.ReadLine());
        Console.Clear();
        
        divisivelPor3(num_1, num_2);
        Console.ReadKey();
    }
        

        static void divisivelPor3(int num_1, int num_2)
        {
            int i;

            if (num_1 > num_2)
            {
                Console.WriteLine(num_2);
                for (i = 0; i < num_1; i++)
                {
                    if (i < num_1 && i > num_2 && i % 2 == 1)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
                Console.WriteLine(num_1);
            }

            else if (num_1 < num_2)
            {
                Console.WriteLine(num_1);
                for (i = 0; i < num_2; i++)
                {
                    if (i < num_2 && i > num_1 && i % 2 == 1)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
                Console.WriteLine(num_2);
            }

            else
            {
                Console.WriteLine("Os números são iguais");
            }
        }
       
    } 