﻿int n = int.Parse(Console.ReadLine());
for (int row = 1; row <= n; row++)
{
    Console.Write("$");
    for (int col = 1; col < row; col++)
    {
        Console.Write(" $");
    }
    Console.WriteLine();

}
