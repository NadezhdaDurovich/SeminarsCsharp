// ДЗ к Семинару №7 «Двумерные массивы»

// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void PrintArray(int m,int n)
// {
//     double [,] array=new double[m,n];
//     for (int i=0;i<m;i++)
//     {
//         for (int j=0;j<n;j++)
//         {
//            int count=new Random().Next(-5,6);
//            array[i,j]=Math.Round(new Random().NextDouble()*count,2);
//            Console.Write($" {array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите желаемое кол-во строк массива: ");
// int m=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите желаемое кол-во столбцов массива: ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Cоздан двухмерный массив [{m}x{n}]: ");
// PrintArray(m,n);

// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void FindIndexOfArrayNubmer(int lineNumber, int columnNumber, int[,] array)
// {
//     if (lineNumber<array.GetLength(0) && columnNumber<array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == lineNumber && j == columnNumber) Console.Write (array[i, j]);
//             }          
//         }
//     }
//     else Console.WriteLine($"Числа c индексом ({lineNumber},{columnNumber}) в данном массиве нет.");
// }
// int[,] PrintArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 101);
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// Console.Write("Введите индекс строки: ");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int m = new Random().Next(2, 5);
// int n = new Random().Next(2, 5);
// Console.WriteLine($"Создан рандомный двухмерный массив[{m}x{n}]");
// int[,] array = PrintArray(m, n);
// Console.WriteLine($"Найдем элемент массива с индексом ({line},{column}): ");
// FindIndexOfArrayNubmer(line, column, array);

// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] PrintArray (int rows,int columns)
{
    int[,] array=new int[rows,columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            array[i,j]=new Random().Next(0,11);
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
double CalculateArithmeticMean (int count, int sum)
{
    double result=Convert.ToDouble(sum)/Convert.ToDouble(count);
    return Math.Round(result,2);
}
int lines=new Random().Next(2,5);
int columns=new Random().Next(2,5);
Console.WriteLine($"Задан массив [{lines}x{columns}] из случайных целых чисел:");
int [,] array=PrintArray (lines,columns);
int sum = 0;
for (int i=0;i<array.GetLength(1);i++)
{
    for (int j=0;j<array.GetLength(0);j++)
    {
        sum=sum+array[j,i];
    }
    Console.WriteLine($"Среднеарифметическа сумма элементов {i} столбца ={CalculateArithmeticMean (lines, sum)}");
    sum=0;
}




