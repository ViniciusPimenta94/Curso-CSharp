using System;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {
            // EX 01
            //string senha = Console.ReadLine();

            //while (senha != "2002") {
            //    Console.WriteLine("Senha Invalida");
            //    senha = Console.ReadLine();
            //}

            //Console.WriteLine("Acesso Permitido");

            // EX 02
            //int x, y;

            //string[] valor = Console.ReadLine().Split(' ');
            //x = int.Parse(valor[0]);
            //y = int.Parse(valor[1]);

            //while (x != 0 && y != 0) {
            //    if (x > 0)
            //        if (y > 0)
            //            Console.WriteLine("Primeiro");
            //        else
            //            Console.WriteLine("Quarto");
            //    else
            //        if (y > 0)
            //            Console.WriteLine("Segundo");
            //        else
            //            Console.WriteLine("Terceiro");

            //    string[] dados = Console.ReadLine().Split(' ');
            //    x = int.Parse(dados[0]);
            //    y = int.Parse(dados[1]);
            //}

            //Ex3 03
            int alcool = 0, gasolina = 0, diesel = 0;

            int n = int.Parse(Console.ReadLine());

            while (n != 4) {
                if (n == 1)
                    alcool += 1;
                else if (n == 2)
                    gasolina += 1;
                else if (n == 3)
                    diesel += 1;

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
