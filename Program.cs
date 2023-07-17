using System;

class Program
{
    public static void Main(string[] args)
    {
        //jogo com dois dados 

        int n, d; //escrever quantas jogadas são 

        Console.Write("Quantas são as jogadas? ");
        n = Convert.ToInt32(Console.ReadLine());

        int[,] plays = new int[n,2]; //ler os números dos dados 

        for(d = 0; d < n; d++)
        {
                do
                {
                    Console.Write("Qual o número do 1º Dado? ");
                    plays[d, 0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Qual o número do 2º Dado? ");
                    plays[d, 1] = Convert.ToInt32(Console.ReadLine());
                } while (plays[d,0] < 1 || plays[d,1] > 6);

            if(plays[d,0] < 1 || plays[d,0] > 6)
            {
                Console.WriteLine();
            }
            
        }


        //quantos vezes saiu o mesmo número nos dois dados
        int cont = 0;

        for(d = 0; d < n; d++)
        {
            if (plays[d,0] == plays[d, 1])
            {
                cont++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Existe " + cont + " doubles");

    }
}
