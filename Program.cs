using System;
using System.Net.Http.Headers;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Digite a operação matemática: ");

            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Sair");
                
                Console.WriteLine("Insira a operação escolhida:");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("--Soma--");
                    Console.Write("Dgite o primeiro número: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Dgite o primeiro número: ");
                    double b = double.Parse(Console.ReadLine());

                    Operacoes op = new Operacoes();
                    double resultado = op.Soma(a, b);
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("--Subtração--");
                    Console.WriteLine("Ecreva o primeiro número");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ecreva o segundo número");
                    b = double.Parse(Console.ReadLine());
                    
                    op = new Operacoes();
                    resultado = op.Subtracao(a, b);
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("--Multiplicação--");
                    Console.Write("Digite o primeiro número: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Digite o primeiro número: ");
                    b = double.Parse(Console.ReadLine());
                    
                    op = new Operacoes();
                    resultado = op.Multiplicacao(a, b);
                    Console.WriteLine("Resultado: " + resultado);
                    
                    break;
                case 4:
                    Console.WriteLine("Dvisão");
                    Console.Write("Dgite o primeiro número: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Dgite o primeiro número: ");
                    b = double.Parse(Console.ReadLine());
                    if (a == 0  || b == 0)
                    {
                        Console.WriteLine("Divisão Impossível.");
                    }
                    else
                    {
                        op = new Operacoes();
                        resultado = op.Dvisao(a, b);
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    break;                        
                case 5:
                    Console.WriteLine("--Potencia--");
                    Console.WriteLine("Digite o valor da base");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do expoente: ");
                    b = double.Parse(Console.ReadLine());

                    resultado = Math.Pow(a, b);
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 6:
                    Console.WriteLine("-- Porcentagem --");
                    Console.Write("Digite o valor base: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Digite a porcentagem que deseja calcular: ");
                    b = double.Parse(Console.ReadLine());
                    
                    op = new Operacoes();
                    resultado = op.Porcetangem(a, b);
                    Console.WriteLine("Resultado: " + resultado);
                    break;
            }
        }
    }
}

