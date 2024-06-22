using System;
using System.Collections.Generic;

public class JumpPointSearch
{
    public static int JumpSearch(int[,] numbers, int startX, int startY, int goalX, int goalY)
    {
        int rows = numbers.GetLength(0);
        int cols = numbers.GetLength(1);
        int step = (int)Math.Sqrt(rows * cols);
        int prev = 0;

        while (numbers[Math.Min(step, rows) - 1, Math.Min(step, cols) - 1] < goalX)
        {
            prev = step;
            step += (int)Math.Sqrt(rows * cols);
            if (prev >= rows * cols)
                return -1;
        }

        while (numbers[prev, Math.Min(step, cols) - 1] < goalX)
        {
            prev++;
            if (prev == Math.Min(step, rows * cols))
                return -1;
        }

        if (numbers[prev, Math.Min(step, cols) - 1] == goalX)
            return prev;

        return -1;
    }

    public static void Main(string[] args)
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

        Console.WriteLine("Введите координаты исходной ячейки: ");
        int startX = int.Parse(Console.ReadLine());
        int startY = int.Parse(Console.ReadLine());
        numbers[startX, startY] = 0;

        int goalX = 4;
        int goalY = 6;

        int steps = JumpSearch(numbers, startX, startY, goalX, goalY);
        
        Console.WriteLine("Количество шагов: " + steps);
    }
}