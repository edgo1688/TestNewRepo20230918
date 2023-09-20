namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrices Practice");

            //llenar una matriz de 3x4 con valores secuenciales
            int[,] matriz = new int[3,6];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = i * matriz.GetLength(1) + j;
                }
            }

            imprimirMatriz(matriz);

            Console.ReadKey();
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
    }
}