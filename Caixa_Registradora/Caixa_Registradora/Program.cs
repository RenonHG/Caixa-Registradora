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
            float VALOR1 = 10, VALOR2 = 20, VALOR3 = 30;
            string PRODUTO1 = "A", PRODUTO2 = "B", PRODUTO3 = "C", frase;
            string loop = "s";
            int QUANTIDADE1 = 10, QUANTIDADE2 = 20, QUANTIDADE3 = 30;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deseja seguir para o menu? (s/n) ");
            loop = (Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n███████ ██ ███████ ████████ ███████ ███    ███  █████          ██████   ██████          ███████ ███████ ██    ██              ██  █████   ██████  \r\n██      ██ ██         ██    ██      ████  ████ ██   ██         ██   ██ ██    ██         ██      ██      ██    ██              ██ ██   ██ ██    ██ \r\n███████ ██ ███████    ██    █████   ██ ████ ██ ███████         ██   ██ ██    ██         ███████ █████   ██    ██              ██ ███████ ██    ██ \r\n     ██ ██      ██    ██    ██      ██  ██  ██ ██   ██         ██   ██ ██    ██              ██ ██      ██    ██         ██   ██ ██   ██ ██    ██ \r\n███████ ██ ███████    ██    ███████ ██      ██ ██   ██         ██████   ██████          ███████ ███████  ██████           █████  ██   ██  ██████  \r\n                                                                                                                                                  \r\n                                                                                                                                                  ");

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
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.WriteLine("\n ██████  █████  ██████   █████  ███████ ████████ ██████   ██████  \r\n██      ██   ██ ██   ██ ██   ██ ██         ██    ██   ██ ██    ██ \r\n██      ███████ ██   ██ ███████ ███████    ██    ██████  ██    ██ \r\n██      ██   ██ ██   ██ ██   ██      ██    ██    ██   ██ ██    ██ \r\n ██████ ██   ██ ██████  ██   ██ ███████    ██    ██   ██  ██████  \r\n                                                                  ");

                    // PRODUTO 1
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nInsira o nome/marca do 1º produto: ");
                    PRODUTO1 = (Console.ReadLine());

                    Console.Write("\nInsira a quantidade em estoque de " + PRODUTO1 + ": ");
                    QUANTIDADE1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInsira o valor de " + PRODUTO1 + ": R$");
                    VALOR1 = float.Parse(Console.ReadLine());

                    //Console.WriteLine("\nproduto cadastrado foi: " + " \n" + PRODUTO1 + "\nquantidade no estoque: " + QUANTIDADE1 + " \nPreço R$" + VALOR1);

                    // PRODUTO 2
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nInsira o nome/marca do 2º produto: ");
                    PRODUTO2 = (Console.ReadLine());

                    Console.Write("\nInsira a quantidade em estoque de " + PRODUTO2 + ": ");
                    QUANTIDADE2 = int.Parse(Console.ReadLine());

                    Console.Write("\nInsira o valor de " + PRODUTO2 + ": R$");
                    VALOR2 = float.Parse(Console.ReadLine());

                    // PRODUTO 3
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nInsira o nome/marca do 3º produto: ");
                    PRODUTO3 = (Console.ReadLine());

                    Console.Write("\nInsira a quantidade em estoque de " + PRODUTO3 + ": ");
                    QUANTIDADE3 = int.Parse(Console.ReadLine());

                    Console.Write("\nInsira o valor de " + PRODUTO3 + ": R$");
                    VALOR3 = float.Parse(Console.ReadLine());

                }

                else if (menu == 2)
                {
                    int cardapio;
                    float recebido, troco;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    //Vendas
                    Console.WriteLine("\n ██████  █████  ██████  ██████   █████  ██████  ██  ██████  \r\n██      ██   ██ ██   ██ ██   ██ ██   ██ ██   ██ ██ ██    ██ \r\n██      ███████ ██████  ██   ██ ███████ ██████  ██ ██    ██ \r\n██      ██   ██ ██   ██ ██   ██ ██   ██ ██      ██ ██    ██ \r\n ██████ ██   ██ ██   ██ ██████  ██   ██ ██      ██  ██████ ");
                    //Console.WriteLine("1: "+p1);

                    Console.WriteLine("Veja nosso cardápio!");
                    //cardapio = (Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n1 - " + PRODUTO1 + " ----- R$ " + VALOR1);
                    Console.WriteLine("\n2 - " + PRODUTO2 + " ----- R$ " + VALOR2);
                    Console.WriteLine("\n3 - " + PRODUTO3 + " ----- R$ " + VALOR3);

                    cardapio = int.Parse(Console.ReadLine());

                    while (cardapio >= 1 || cardapio <= 3)
                    {
                        if (cardapio == 1)
                        {
                            int desejada1;

                            Console.WriteLine("\nVocê escolheu: " + PRODUTO1 + " Que custa R$" + VALOR1 + " por unidade, quantidade no estoque: " + QUANTIDADE1);
                            Console.WriteLine("\nQuantas unidades você deseja? ");
                            desejada1 = int.Parse(Console.ReadLine());

                            if (desejada1 <= QUANTIDADE1)
                            {
                                float total1;

                                total1 = desejada1 * VALOR1;

                                Console.WriteLine("\nFicou um valor total de: R$" + total1);

                                Console.Write("\nValor recebido: R$");
                                recebido = float.Parse(Console.ReadLine());

                                if (recebido < total1)
                                {
                                    Console.WriteLine("\nVaza pobre!");
                                }
                                else
                                {
                                    troco = recebido - total1;
                                    Console.WriteLine("\nTroco: R$" + troco);
                                    QUANTIDADE1 -= desejada1;

                                    Console.Write("Venda Realizada!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantidade indisponível!!!");

                            }
                        }

                        else if (cardapio == 2)
                        {
                            int desejada2;

                            Console.WriteLine("\nVocê escolheu: " + PRODUTO2 + " Que custa R$" + VALOR2 + " por unidade, quantidade no estoque: " + QUANTIDADE2);
                            Console.WriteLine("\nQuantas unidades você deseja? ");
                            desejada2 = int.Parse(Console.ReadLine());

                            if (desejada2 <= QUANTIDADE2)
                            {
                                float total2;

                                total2 = desejada2 * VALOR2;

                                Console.WriteLine("\nFicou um valor total de: R$" + total2);

                                Console.Write("\nValor recebido: R$");
                                recebido = float.Parse(Console.ReadLine());

                                if (recebido < total2)
                                {
                                    Console.WriteLine("\nVaza pobre!");
                                }
                                else
                                {
                                    troco = recebido - total2;
                                    Console.WriteLine("\nTroco: R$" + troco);
                                    QUANTIDADE2 -= desejada2;

                                    Console.Write("Venda Realizada!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantidade indisponível!!!");

                            }
                        }
                        
                        else if (cardapio == 3)
                        {
                            int desejada3;

                            Console.WriteLine("\nVocê escolheu: " + PRODUTO3 + " Que custa R$" + VALOR3 + " por unidade, quantidade no estoque: " + QUANTIDADE2);
                            Console.WriteLine("\nQuantas unidades você deseja? ");
                            desejada3 = int.Parse(Console.ReadLine());

                            if (desejada3 <= QUANTIDADE3)
                            {
                                float total3;

                                total3 = desejada3 * VALOR3;
                                Console.WriteLine("\nFicou um valor total de: R$" + total3);

                                Console.Write("\n Valor recebido: R$");
                                recebido = float.Parse(Console.ReadLine());

                                if (recebido < total3)
                                {
                                    Console.WriteLine("\nVaza pobre!");
                                }
                                else
                                {
                                    troco = recebido - total3;
                                    Console.WriteLine("\nTroco: R$" + troco);
                                    QUANTIDADE3 -= desejada3;

                                    Console.Write("Venda Realizada!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantidade indisponível!!!");

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpção indisponível, escolha outra opção!");
                            cardapio = int.Parse(Console.ReadLine());

                        }
                        break;

                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("\nDeseja mais alguma coisa do cardápio?");
                        //cardapio = int.Parse(Console.ReadLine());
                    }

                }

                else if (menu == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n██████  ███████ ██       █████  ████████  ██████  ██████  ██  ██████  \r\n██   ██ ██      ██      ██   ██    ██    ██    ██ ██   ██ ██ ██    ██ \r\n██████  █████   ██      ███████    ██    ██    ██ ██████  ██ ██    ██ \r\n██   ██ ██      ██      ██   ██    ██    ██    ██ ██   ██ ██ ██    ██ \r\n██   ██ ███████ ███████ ██   ██    ██     ██████  ██   ██ ██  ██████  \r\n                                                                      ");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n- Produto 1: " + PRODUTO1 + "\n- Estoque: " + QUANTIDADE1 + " \n- Valor R$" + VALOR1);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n- Produto 2: " + PRODUTO2 + "\n- Estoque: " + QUANTIDADE2 + " \n- Valor R$" + VALOR2);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n- Produto 3: " + PRODUTO3 + "\n- Estoque: " + QUANTIDADE3 + " \n- Valor R$" + VALOR3);

                }

                else if (menu == 4)
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

                Console.WriteLine("\nDeseja Voltar para o Menu? (s/n) ");
                loop = Console.ReadLine();


            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nAperte qualquer tecla para encerrar o programa!");
            Console.ReadKey();
        }
    }
}
