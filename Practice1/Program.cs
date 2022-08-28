// Показать двумерный массив размером m×n заполненный вещественными числами
double[,] mass = new double[3,4];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j]=new Random().NextDouble(); 
        Console.Write("{0,6:F2}",mass[i,j]);
    }
Console.WriteLine();
}