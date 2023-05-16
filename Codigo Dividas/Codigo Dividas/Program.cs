using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Codigo_Dividas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDividas = 0;
            int porcentagemInvestida = 0;
            int fixoInvestido = 0;
            double final = 0;
            double somaDividas = 0;
            string escolhaUser = "";
            double salario = 0;

            Console.WriteLine("Quantas dividas você tem esse mês? (Lembrando que as dividas dentro de cada cartão de crédito se resumem em 1 divida apenas)");
            Console.WriteLine("Reuna todas as dividas e coloque o numero de dividas a baixo: ");
            numDividas = int.Parse(Console.ReadLine());

            double[] varsDividas = new double[numDividas];

            for (int i = 0; i < numDividas; i++)
            {
                Console.WriteLine("Digite o valor da " + (i + 1) + "° Divida.");
                varsDividas[i] = double.Parse(Console.ReadLine()); //atribui o valor lido ao elemento i do array
            }
            Console.WriteLine("O valor das Total das suas dividas desse mês é " + varsDividas.Sum());
            Console.WriteLine("Você guarda algum dinheiro ou investe? Digite S para Sim e N para não.");
            escolhaUser = Console.ReadLine();
            if(escolhaUser == "S" || escolhaUser == "s")
            {
                Console.WriteLine("Quando você investe, você investe uma porcentagem ou um valor fixo?");
                Console.WriteLine("Digite % para se investe uma porcentagem do salario ou Digite fixo, para um valor fixo.");
                escolhaUser = Console.ReadLine();
                if (escolhaUser == "%" || escolhaUser == "5") 
                {
                    Console.WriteLine("Quantos % do seu salario fixo você investe ao mês? (digite o numero SEM o sinal de %)");
                    porcentagemInvestida = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o seu salario aqui para fazermos o calculo.");
                    salario = double.Parse(Console.ReadLine());

                    final = salario - (porcentagemInvestida * salario / 100) - varsDividas.Sum();
                    Console.WriteLine("O valor que sobrará do seu salario após o pagamento de todas as Dividas e Investir será: " + final);
                }
                else
                {
                    Console.WriteLine("Digite o Valor fixo mensal que você separa para ivestimentos!");
                    fixoInvestido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o seu salario aqui para fazermos o calculo.");
                    salario = double.Parse(Console.ReadLine());

                    final = salario - fixoInvestido - varsDividas.Sum();
                    Console.WriteLine("O valor que sobrará do seu salario após o pagamento de todas as Dividas e Investir será: " + final);
                }

            }
            else
            {
                somaDividas = varsDividas.Sum();
                Console.WriteLine("Certo, quer saber o quanto sobrará do seu salario após todas as dividas pagas?");
                escolhaUser = Console.ReadLine();
                if(escolhaUser == "s" || escolhaUser == "S")
                {
                    Console.WriteLine("Digite o valor do seu salario sem sibolos ou virgula (Ex: 1800)");
                    salario = double.Parse(Console.ReadLine());

                    final = salario - varsDividas.Sum();
                    Console.WriteLine("O valor que sobrará do seu salario após o pagamento de todas as Dividas será: " + final);
                }
                else
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            
            Console.ReadKey();
        }
    }
}
