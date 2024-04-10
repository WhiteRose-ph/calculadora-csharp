using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Selecione a operação que deseja");
                Console.WriteLine("(1) Adição");
                Console.WriteLine("(2) Subtração");
                Console.WriteLine("(3) Multiplicação");
                Console.WriteLine("(4) Divisão");

                int operador = int.Parse(Console.ReadLine());  // int.Parse > Quando digitamos um número no console, ele entra como string/texto. 
                                                               //Esse Parse serve para converter a representação do número 2 para um número inteiro
                                                               // Console.ReadLine > Le e armazena a informação inserida pelo usuário


                string operadorTexto = "";

                if (operador == 1)
                {
                    operadorTexto = "adição";
                }
                if (operador == 2)
                {
                    operadorTexto = "subtração";
                }
                if (operador == 3)
                {
                    operadorTexto = "multiplicação";
                }
                if (operador == 4)
                {
                    operadorTexto = "divisão";
                }


                Console.WriteLine("Digite o primeiro número da sua operação:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número da sua operação:");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;

                switch (operador)
                {
                    case 1:
                        resultado = Adicao(num1, num2);
                        break;
                    case 2:
                        resultado = Subtracao(num1, num2);
                        break;
                    case 3:
                        resultado = Multiplicacao(num1, num2);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = Divisao(num1, num2);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por 0");
                            continue; // Volta ao início do loop para solicitar uma nova operação
                        }
                        break;

                    default:
                        Console.WriteLine("Selecione um número correspondente a um operador!");
                        continue; // Volta ao início do loop para solicitar uma nova operação
                }


                Console.WriteLine("O resultado da {0} entre {1} e {2} é {3}", operadorTexto, num1, num2, resultado);
                Console.WriteLine(" ");
                Console.WriteLine("O que deseja fazer agora?");
                Console.WriteLine("1 - Fazer nova operação");
                Console.WriteLine("2 - Encerrar programa");

                if (!int.TryParse(Console.ReadLine(), out int escolha))
                {
                    Console.WriteLine("Por favor, escolha uma opção válida!");
                    return;
                }
                if (escolha != 1)
                {
                    Console.WriteLine("Programa encerrado");
                    Environment.Exit(1); //encerra o programa
                }


            } while (true);

        }

            
        public static int Adicao (int num1, int num2)  //essas variáveis declaradas dentro dos métodos são locais
        {
            int resultado = num1 + num2;
            return resultado;
            }
        public static int Subtracao(int num1, int num2)  
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public static int Multiplicacao(int num1, int num2)  
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public static int Divisao(int num1, int num2)  
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}