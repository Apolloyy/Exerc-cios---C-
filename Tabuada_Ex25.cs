using System;

class Program
{

    static void Main(string[] args)
    { 
        tabuada();
        Console.ReadKey();
    }
    static void tabuada()
    {
        int num, i;
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        
        for (i = 0; i < 11; i++)
        {
            Console.Write("\n{0}x{1}={2}", num, i, i*num);
        }
    }
}