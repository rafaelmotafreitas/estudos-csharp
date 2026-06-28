using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    internal class Exercicio1
    {
        internal void teste()
        {
            Console.Write("Digite o score de crédito do cliente (0 a 1000): ");
            int score = int.Parse(Console.ReadLine());

            if (score == 0)
            {
                Console.WriteLine("O empréstimo está bloqueado, voce está inadiplente.");
                return;
            }
            if (score > 1000)
            {
                Console.WriteLine("Score inválido, não é possível realizar o empréstimo.");
                return;
            }

            Console.Write("Digite o valor solicitado (R$): ");
            double valorSolicitado = double.Parse(Console.ReadLine());

            double valorTotal = 0;
            double taxaJuros = 0;
            string decisao = "";


            if (score < 300)
            {
                decisao = "EMPRÉSTIMO BLOQUEADO";

                Console.WriteLine("Empréstimo bloqueado, score abaixo do mínimo.");

                return;
            }
            else if (score >= 300 && score <= 699)
            {
                decisao = "APROVADO COM ALTO RISCO";
                taxaJuros = 5.0;
            }
            else
            {
                taxaJuros = 1.5;
                decisao = "APROVADO COM BAIXO RISCO";
            }

            valorTotal = valorSolicitado * (1 + (taxaJuros / 100) * 12);

            Console.WriteLine(decisao);
            Console.WriteLine($"O score é: {score}");
            Console.WriteLine($"O juros aplicado é: {taxaJuros}");
            Console.WriteLine($"Valor total do empréstimo:{valorTotal:C}");

            // Verifique se o score é menor que 300
            // Se sim, defina a decisão como "EMPRÉSTIMO BLOQUEADO" e encerre sem calcular juros

            // Verifique se o score está entre 300 e 699 (inclusive)
            // Se sim, defina taxaJuros como 5.0 e decisao como "APROVADO COM ALTO RISCO"

            // Para qualquer score acima de 699
            // Defina taxaJuros como 1.5 e decisao como "APROVADO COM BAIXO RISCO"

            // Calcule o valor total a pagar após 12 parcelas com juros simples
            // Fórmula: valorTotal = valorSolicitado * (1 + (taxaJuros / 100) * 12)

            // Exiba: decisão, score, taxa aplicada e valor total a pagar formatado em moeda
        }
    }
}
