namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, m];

            Console.Write("Введите координаты исходной ячейки: ");
            int startX = int.Parse(Console.ReadLine());
            int startY = int.Parse(Console.ReadLine());
            numbers[startX, startY] = 0;

            int goalX = 4;
            int goalY = 6;
            int[,] heuristic = new int[numbers.GetLength(0), numbers.GetLength(1)];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    heuristic[i, j] = Math.Abs(i - goalX) + Math.Abs(j - goalY);
                }
            }

            Console.WriteLine("Эвристика Манхэттена:");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write("{0,4}", heuristic[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

