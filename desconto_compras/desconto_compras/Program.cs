using System;
using System.Diagnostics.Eventing.Reader;

namespace desconto_compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 0;
            int valorDesconto = 0;
            bool flag = false;
            string aniversariante;

            try
            {
                while (!flag)
                {
                    Console.Write("Digite o valor da compra ou 'S' para sair: ");
                    string inputCompra = Console.ReadLine();

                    if (inputCompra.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa finalizado.");
                        return;
                    }

                    try
                    {
                        valorCompra = double.Parse(inputCompra);
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }
                flag = false;

                while (!flag)
                {
                    Console.Write("Digite a porcentagem de desconto (0 a 100) ou 'S' para sair: ");
                    string inputDesconto = Console.ReadLine();
                        
                    if (inputDesconto.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa finalizado.");
                        return;
                    }

                    try
                    {
                        valorDesconto = int.Parse(inputDesconto);

                        if (valorDesconto < 0 || valorDesconto > 100)
                        {
                            Console.WriteLine("Erro: A porcentagem de desconto deve estar entre 0 e 100.");
                            continue;
                        }

                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }
                double valorFinal = valorCompra - (valorCompra * (valorDesconto / 100.0));
                Console.WriteLine($"Valor final com desconto: {valorFinal:C}");
            }
            finally
            {
                Console.WriteLine("Operação finalizada.");
                Console.ReadLine();
            }
        }
    }
}