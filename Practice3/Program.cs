// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] mass = new int[5, 5];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(5, 5);
        Console.Write($" {mass[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int n = 0; n < mass.GetLength(0); n++)
{
    for (int m = 0; m < mass.GetLength(1); m++)
    {
        if (n % 2 == 0 && m % 2 == 0)
        {
            mass[n, m] = mass[n, m] * mass[n, m];
        }
        Console.Write($" {mass[n, m]} ");
    }
    Console.WriteLine();
}