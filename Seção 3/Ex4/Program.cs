using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {
            // EX 01
            //int x;

            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= x; i+=2) {
            //    Console.WriteLine(i);
            //}

            // EX 02
            //int n, x, dentro = 0, fora = 0;

            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < n; i++) {
            //    x = int.Parse(Console.ReadLine());

            //    if (x >= 10 && x <= 20)
            //        dentro += 1;
            //    else
            //        fora += 1;
            //}

            //Console.WriteLine();
            //Console.WriteLine($"{dentro} in");
            //Console.WriteLine($"{fora} out");

            // EX 03
            //double n1, n2, n3, media;

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < n; i++) {
            //    string[] dados = Console.ReadLine().Split(' ');
            //    n1 = double.Parse(dados[0], CultureInfo.InvariantCulture);
            //    n2 = double.Parse(dados[1], CultureInfo.InvariantCulture);
            //    n3 = double.Parse(dados[2], CultureInfo.InvariantCulture);

            //    media = ((n1*2)+(n2*3)+(n3*5))/10;
            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //    Console.WriteLine();
            //}

            // EX 04
            //double n1, n2, divisao;

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < n; i++) {
            //    string[] dados = Console.ReadLine().Split(' ');
            //    n1 = int.Parse(dados[0]);
            //    n2 = int.Parse(dados[1]);

            //    if (n2 != 0) {
            //        divisao = n1 / n2;
            //        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //    else
            //        Console.WriteLine("Divisão Impossível");

            //    Console.WriteLine();
            //}

            // EX 05
            //int n, fatorial = 1;

            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {
            //    fatorial = fatorial*i;
            //}
            //Console.WriteLine(fatorial);

            // EX 06
            //int n;

            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) { 
            //    if (n % i == 0)
            //        Console.WriteLine(i);
            //}

            // EX 07
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}