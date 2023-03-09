/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int a;
int d;
Console.Write($"Введите количество строк: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out d);

int[,] array = new int[a, d];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}, ");
    }
    Console.WriteLine();
}

//double result = 0;
double c = 0;
for (int i = 0; i < array.GetLength(0); i++)
{   double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
    c = result / array.GetLength(0);
    Console.Write($"{c}, ");

    //return result;
}
Console.WriteLine();