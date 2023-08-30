using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Registradora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            float CAPACIDADE, VALOR;
            string PRODUTO, frase;
            string loop = "s";

            Console.WriteLine("Deseja seguir para o menu? (s/n) ");
            loop = (Console.ReadLine());

            while (loop.ToLower() == "s")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Escolha a opção desejada nesse menu: ");
                Console.WriteLine("1: CADASTRO");
                Console.WriteLine("2: VENDA");
                Console.WriteLine("3: RELATÓRIO");
                Console.WriteLine("4: Area de testes!!!");
                menu = int.Parse(Console.ReadLine());

                //Console.ResetColor();

                if (menu == 1)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Bem vindo ao CADASTRO");

                    Console.Write("Insira o nome/marca do produto: ");
                    PRODUTO = (Console.ReadLine());

                    Console.Write("Insira a capacidade do produto: ");
                    CAPACIDADE = float.Parse(Console.ReadLine());

                    Console.Write("Insira o valor do produto: R$");
                    VALOR = float.Parse(Console.ReadLine());

                    Console.WriteLine("\nO produto cadastrado foi: " + " \n" + PRODUTO + " capacidade: " + CAPACIDADE + " \nPreço R$" + VALOR);



                }

                else if (menu == 2)
                {
                    string cardapio;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine("Ótimo, vamos seguir com a venda, escolha um número do cardápio ");
                    //Console.WriteLine("1: "+p1);
                    Console.WriteLine("");
                    cardapio = (Console.ReadLine());






                }

                else if (menu == 3)
                {







                }
                else if(menu == 4)
                {
                    Console.Write("Digite uma frase: ");
                    frase = Console.ReadLine();

                    Console.WriteLine(frase.ToUpper());
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha uma opção válida!");
                }

                Console.WriteLine("Deseja Voltar para o Menu? (s/n) ");
                loop = Console.ReadLine();
            
            
            
            }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAperte qualquer tecla para encerrar o programa!");
                Console.ReadKey();
        }
    }
}
