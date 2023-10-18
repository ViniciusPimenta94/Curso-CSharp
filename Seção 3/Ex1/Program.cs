using System;
using System.Globalization;
using System.Xml.Schema;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            // EX 01
            // int n1, n2, soma;

            // n1 = int.Parse(Console.ReadLine());
            // n2 = int.Parse(Console.ReadLine());

            // soma = n1 + n2;
            // Console.WriteLine($"SOMA = {soma}");

            // EX 02
            //double raio, pi, area;

            //pi = 3.14159;
            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * raio * raio;
            //Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");

            // EX 03
            //int A, B, C, D, diferenca;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());

            //diferenca = (A * B - C * D);
            //Console.WriteLine($"DIFERENÇA = {diferenca}");

            // EX 04
            //int n, h;
            //double valor, salario;

            //n = int.Parse(Console.ReadLine());
            //h = int.Parse(Console.ReadLine());

            //valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = h * valor;
            //Console.WriteLine($"NUMBER = {n}");
            //Console.WriteLine($"SALARY = {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            // EX 05
            //int cod1, qtd1, cod2, qtd2;
            //double valor1, valor2, total;

            //string[] dados1 = Console.ReadLine().Split(' ');
            //cod1 = int.Parse(dados1[0]);
            //qtd1 = int.Parse(dados1[1]);
            //valor1 = double.Parse(dados1[2], CultureInfo.InvariantCulture);

            //string[] dados2 = Console.ReadLine().Split(' ');
            //cod2 = int.Parse(dados2[0]);
            //qtd2 = int.Parse(dados2[1]);
            //valor2 = double.Parse(dados2[2], CultureInfo.InvariantCulture);

            //total = (qtd1 * valor1) + (qtd2 * valor2);
            //Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            // EX 06
            double A, B, C, pi = 3.14159;
            double triangulo, circulo, trapezio, quadrado, retangulo;

            string[] dados = Console.ReadLine().Split(' ');
            A = double.Parse(dados[0], CultureInfo.InvariantCulture);
            B = double.Parse(dados[1], CultureInfo.InvariantCulture);
            C = double.Parse(dados[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            circulo = pi * C * C;
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            trapezio = ((A + B) * C) / 2;
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            quadrado = B * B;
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            retangulo = A * B;
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
