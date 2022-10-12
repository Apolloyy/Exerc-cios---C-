using System;

class Program
{

    static void Main(string[] args)
    {
        double[] notas = new double[10];
        double mediaNotas = 0;

        getNotas(notas);
        Console.Clear();
        getMedias(notas, mediaNotas);
        Console.ReadKey();
    }
    static void getNotas(double[] notas)
    {
        int i;
        double teste;
        for(i = 0; i<notas.Length; i++)
        {
            Console.WriteLine("Digite a {0}° nota: ", i+1);
            notas[i] = double.Parse(Console.ReadLine());

            if (notas[i] > 10)
            {
                Console.WriteLine("");
                Console.WriteLine("Erro, nota maior que 10!");
                notas[i] = 10;
                Console.WriteLine("A nota foi igualada a 10!");
                Console.WriteLine("");
            }

            else
            {
                teste = notas[i];
            }
        }
        
    }
    static void getMedias(double[] notas, double mediaNotas)
    {
        double trueMedia;
        mediaNotas = notas[0] + notas[1] + notas[2] + notas[3] + notas[4] + notas[5] + notas[6] + notas[7] + notas[8] + notas[9];
        trueMedia = mediaNotas / 10;
        Console.Write("\nA  média de notas foi: {0:N2}", trueMedia);
    }
}