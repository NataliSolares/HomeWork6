// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] mass = new int[3, 4];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i+j;
        Console.Write($" {mass[i, j]} ");
    }
    Console.WriteLine();
}

