using System;
using System.Globalization;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            // EX 01
            //int n;

            //n = int.Parse(Console.ReadLine());

            //if (n >= 0)
            //    Console.WriteLine("NAO NEGATIVO");
            //else
            //    Console.WriteLine("NEGATIVO");

            // EX 02
            //int n;

            //n = int.Parse(Console.ReadLine());

            //if (n % 2 == 0)
            //    Console.WriteLine("PAR");
            //else
            //    Console.WriteLine("ÍMPAR");

            // EX 03
            //int A, B;

            //string[] dados = Console.ReadLine().Split(' ');
            //A = int.Parse(dados[0]);
            //B = int.Parse(dados[1]);

            //if (A > B)
            //    if (A % B == 0)
            //        Console.WriteLine("São Múltiplos");
            //    else
            //        Console.WriteLine("Não são Múltiplos");
            //else
            //    if (B % A == 0)
            //        Console.WriteLine("São Múltiplos");
            //    else
            //        Console.WriteLine("Não são Múltiplos");

            // EX 04
            //int inicio, fim;

            //string[] dados = Console.ReadLine().Split(' ');
            //inicio = int.Parse(dados[0]);
            //fim = int.Parse(dados[1]);

            //if (fim > inicio)
            //    Console.WriteLine($"O JOGO DUROU {fim - inicio} HORA(S)");
            //else
            //    Console.WriteLine($"O JOGO DUROU {24 - inicio + fim} HORA(S)");

            // EX 05
            //int cod, qtd;
            //double total;

            //string[] dados = Console.ReadLine().Split(' ');
            //cod = int.Parse(dados[0]);
            //qtd = int.Parse(dados[1]);

            //if (cod == 1)
            //    total = 4 * qtd;
            //else if (cod == 2)
            //    total = 4.5 * qtd;
            //else if (cod == 3)
            //    total = 5 * qtd;
            //else if (cod == 4)
            //    total = 2 * qtd;
            //else
            //    total = 1.5 * qtd;

            //Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            // EX 06
            //double valor;

            //valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (valor < 0 || valor > 100)
            //    Console.WriteLine("Fora de Intervalo");
            //else if (valor <= 25)
            //    Console.WriteLine("Intervalo [0, 25]");
            //else if (valor <= 50)
            //    Console.WriteLine("Intervalo (25, 50]");
            //else if (valor <= 75)
            //    Console.WriteLine("Intervalo (50, 75]");
            //else
            //    Console.WriteLine("Intervalo (75, 100]");

            // EX 07
            //double x, y;

            //string[] dados = Console.ReadLine().Split(' ');
            //x = double.Parse(dados[0], CultureInfo.InvariantCulture);
            //y = double.Parse(dados[1], CultureInfo.InvariantCulture);

            //if (x == 0 && y == 0)
            //    Console.WriteLine("Origem");
            //else if (x == 0)
            //    Console.WriteLine("Eixo Y");
            //else if (y == 0)
            //    Console.WriteLine("Eixo X");
            //else if (x > 0)
            //    if (y > 0)
            //        Console.WriteLine("Q1");
            //    else
            //        Console.WriteLine("Q4");
            //else
            //    if (y > 0)
            //        Console.WriteLine("Q2");
            //    else
            //        Console.WriteLine("Q3");

            // EX 08
            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 4500)
                imposto = (1000 * 0.08) + (1500 * 0.18) + (salario - 4500) * 0.28;
            else if (salario > 3000)
                imposto = (1000 * 0.08) + (salario - 3000) * 0.18;
            else if (salario > 2000)
                imposto = (salario - 2000) * 0.08;
            else
                imposto = 0;

            if (imposto > 0)
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            else
                Console.WriteLine("ISENTO");
        }
    }
}