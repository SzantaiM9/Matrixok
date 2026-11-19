namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static int[,] negyzetesMatrix = new int[5, 5];
        static Random r = new Random();
        static void F01(int[,] matrix, int min, int max)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max+1);
                }
            }
        }
        static void F02(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 5} ");
                }
                Console.WriteLine();
            }
        }

        static void F03()
        {
            int ossz = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
            }
            Console.WriteLine($"A mátrix elemeinek összege: {ossz}");
        }
        static void F04()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                int ossz = 0;
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"Az {i + 1}. sor elemeinek összege: {ossz}");
            }
        }

        static void F05()
        {
            for (int j = 0; j < oszlopokSzama; j++)
            {
                int ossz = 0;
                for (int i = 0; i < sorokSzama; i++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"Az {j + 1}. oszlop elemeinek összege: {ossz}");
            }
        }
        static void BalAtloOsszeg(int[,] matrix)
        {
            int ossz = 0;
            Console.Write("A bal átló:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, i], 5} ");
                ossz += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A bal átló elemeinek összege: {ossz}");
        }
        static void JobbAtloOsszeg(int[,] matrix)
        {
            int ossz = 0;
            Console.Write("A jobb átló:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, matrix.GetLength(1) - 1 - i],5} ");
                ossz += matrix[i, matrix.GetLength(1) - 1 - i];
            }
            Console.WriteLine();
            Console.WriteLine($"A jobb átló elemeinek összege: {ossz}");
        }
        static void Main(string[] args)
        {
            F01(szamokMatrix, 10, 99);
            F02(szamokMatrix);
            F03();
            F04();
            F05();

            Console.WriteLine("---------------------------------------");
            F01(negyzetesMatrix, -100, 100);
            F02(negyzetesMatrix);
            BalAtloOsszeg(negyzetesMatrix);
            JobbAtloOsszeg(negyzetesMatrix);


            int[,] masolat = negyzetesMatrix;
            masolat[0, 0] = 100;
            Console.WriteLine("A másolat első eleme: ");
            F02(masolat);
            Console.WriteLine("A négyzetes mátrix első eleme: ");
            F02(negyzetesMatrix);
        }
    }
}
