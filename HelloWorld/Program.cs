namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrices Practice");            

            // int[,] enteros = {
            //     { 1, 2 },
            //     { 3, 4 },
            //     { 5, 6 },
            //     { 7, 8 }
            //     };

            // imprimirMatriz(enteros);


            int[,] matriz = new int[5, 5];

            inicializarMatriz(matriz);
            imprimirMatriz(matriz);

            //encontrar el menor y el mayor valor, e imprimirlos con sus posiciones
            int i_min = 0, j_min = 0;
            int i_max = 0, j_max = 0;
            
            int min = matriz[i_min,j_min];
            int max = matriz[i_max,j_max];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] < min)
                    {
                        min = matriz[i,j];
                        i_min = i;
                        j_min = j;
                    }

                    if (matriz[i,j] > max)
                    {
                        max = matriz[i,j];
                        i_max = i;
                        j_max = j;
                    }
                }
            }

            Console.WriteLine($"El valor mínimo es: {min} y se encuentra en la posición [{i_min},{j_min}]");
            Console.WriteLine($"El valor máximo es: {max} y se encuentra en la posición [{i_max},{j_max}]");

            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.Write($"{Environment.NewLine}Press any key to exit...");
            // int c = 0;
            // Console.WriteLine("The series is:");

            // for (int i = 1; i < 10; i++)
            // {
            //     c = c + i;
            //     Console.Write(c + " ");
            // }

            Console.WriteLine("\nPress Enter key to exit the process...");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public static void imprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void inicializarMatriz(int[,] matriz){
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = r.Next(100);
                }
            }
        }
    }
}