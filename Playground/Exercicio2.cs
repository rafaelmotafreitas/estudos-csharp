using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    internal class Exercicio2
    {

        internal void test()
        {
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.Write("Digite o total de aulas no mês: ");
            int totalAulas = int.Parse(Console.ReadLine());

            if (totalAulas <= 0)
            {
                Console.WriteLine("Não houveram aulas.");
                return;
            }

            int totalPresencas = 0;

            for (int i = 1; i <= totalAulas; i++)
            {
                Console.WriteLine("Digite um valor (0 para ausência e 1 para presença):");

                int valorDigitado = int.Parse(Console.ReadLine());

                Console.WriteLine($"Valor digitado: {valorDigitado}");

                if (valorDigitado == 1)
                {
                    totalPresencas++;
                }
            }

            Console.WriteLine($"O total de presenças é: {totalPresencas}");



            // Crie um loop FOR que percorra cada aula de 1 até totalAulas
            // Em cada iteração, leia um valor (1 ou 0) informando presença ou falta
            // Acumule as presenças no contador totalPresencas

            double percentualFrequencia = (double)totalPresencas / totalAulas * 100;
            Console.WriteLine($"Aluno: {nomeAluno}");
            Console.WriteLine($"Percentual de frequencia: {percentualFrequencia}");

            if (percentualFrequencia < 50.00)
            {
                Console.WriteLine("REPROVADO POR FALTA");
            }
            else if (percentualFrequencia >= 50.00 && percentualFrequencia <= 74.99)
            {
                Console.WriteLine("EM RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("APROVADP POR FREQUÊNCIA.");
            }

            // Calcule o percentual: totalPresencas / totalAulas * 100
            // Atenção: garanta divisão em ponto flutuante, não inteira

            // Exiba o nome do aluno e o percentual formatado com uma casa decimal

            // Verifique o percentual e exiba:
            // "APROVADO POR FREQUÊNCIA" se for 75% ou mais
            // "EM RECUPERAÇÃO" se estiver entre 50% e 74.99%
            // "REPROVADO POR FALTA" se for abaixo de 50%
        }
    }
}
