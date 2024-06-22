namespace LabWork4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = -1;
                }
            }

            Random random = new();
            int obstacleCount = random.Next(1, n * m / 4);

            for (int i = 0; i < obstacleCount; i++)
            {
                int x = random.Next(0, n);
                int y = random.Next(0, m);
                numbers[x, y] = -2;
            }

            Console.WriteLine("Введите координаты исходной ячейки: ");
            int startX = int.Parse(Console.ReadLine());
            int startY = int.Parse(Console.ReadLine());
            numbers[startX, startY] = 0;

            int finishX, finishY;
            do
            {
                finishX = random.Next(0, n);
                finishY = random.Next(0, m);
            }
            while (finishX == startX && finishY == startY || numbers[finishX, finishY] == -2);
            numbers[finishX, finishY] = 99;

            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int goalX = 3;
            int goalY = 3;

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    int h = Math.Abs(x - goalX) + Math.Abs(y - goalY);
                    numbers[x, y] = h;
                }
            }

            Console.WriteLine("Массив с полученными значениями: ");
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    Console.Write(numbers[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
