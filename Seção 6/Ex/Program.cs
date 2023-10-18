using System;

namespace Ex {
    class Program {
        static void Main(string[] args) {
            string[] matriz = Console.ReadLine().Split(' ');
            int m = int.Parse(matriz[0]);
            int n = int.Parse(matriz[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (num == mat[i, j]) {
                        Console.WriteLine($"\nPosition {i},{j}");

                        if (j - 1 >= 0)
                            Console.WriteLine($"Left: {mat[i, j - 1]}");

                        if (j + 1 < n)
                            Console.WriteLine($"Right: {mat[i, j + 1]}");

                        if (i + 1 < m)
                            Console.WriteLine($"Down: {mat[i + 1, j]}");

                        if (i - 1 >= 0)
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                    }
                }
            }
        }
    }
}