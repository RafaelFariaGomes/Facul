using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int X = 0;
            Boolean esta = false;

            Console.WriteLine("Digite o valor de X!");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 10 numeros para o vetor!");
            vetor1[0] = int.Parse(Console.ReadLine());
            vetor1[1] = int.Parse(Console.ReadLine());
            vetor1[2] = int.Parse(Console.ReadLine());
            vetor1[3] = int.Parse(Console.ReadLine());
            vetor1[4] = int.Parse(Console.ReadLine());
            vetor1[5] = int.Parse(Console.ReadLine());
            vetor1[6] = int.Parse(Console.ReadLine());
            vetor1[7] = int.Parse(Console.ReadLine());
            vetor1[8] = int.Parse(Console.ReadLine());
            vetor1[9] = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                if (vetor1[i] == X)
                {
                    esta = true;
                }
                else
                {
                    esta = false;
                }
            }
            if(esta == true)
            {
                Console.WriteLine("X está presente no Vetor");
            }
            else
            {
                Console.WriteLine("X NÃO está presente no Vetor");
            }
            Console.ReadKey();
        }
    }
}
