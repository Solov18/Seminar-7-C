/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
 двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет*/

int rows;
int colums;
Console.Write($"Введите индекс строки: ");
int.TryParse(Console.ReadLine()!, out rows);
Console.Write($"Введите индекс столбца: ");
int.TryParse(Console.ReadLine()!, out colums);

int[,] num = new int[5, 6]; // Массив 

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]}, ");
    }
    Console.WriteLine();
}
if (rows < num.GetLength(0) && colums < num.GetLength(1))
{
    Console.WriteLine($"{num[rows,colums]} индекс этого элемента ");
}

else Console.Write($"{rows},{colums} -> такого числа в массиве нет \n");
