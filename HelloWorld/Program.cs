namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrices Practice");

            //int[,] matriz = new int[3, 3];

            int[,] cadenas = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            imprimirMatriz(cadenas);
            
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {

            //         //Console.WriteLine(matriz[i, j]);
            //     }
            // }

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

        public static void imprimirMatriz(int[,] matriz){
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}