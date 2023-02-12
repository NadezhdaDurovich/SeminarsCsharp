// Семинар №8. Двумерные массивы. Продолжение

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] PrintNewArray()
// {
//     int m = new Random().Next(2, 5);
//     int n = new Random().Next(2, 6);
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
// int [,] SortArray(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int maxElementIndex = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, maxElementIndex])
//                 {
//                     maxElementIndex = k;
//                 }
//             }
//             temp = array[i, j];
//             array[i, j] = array[i, maxElementIndex];
//             array[i, maxElementIndex] = temp;
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Задан рандомный массив:");
// int[,] array = PrintNewArray();
// Console.WriteLine();
// PrintArray(SortArray(array));

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка.

// int[,] PrintNewRectangularArray()
// {
//     int m = new Random().Next(3, 6);
//     int n = new Random().Next(3, 6);
//     while (n >= m)
//     {
//         n--;
//     }
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
// Console.WriteLine($"Задан двумерный прямоугольный массив:");
// int[,] array = PrintNewRectangularArray();
// int sum = 0;
// int minSum = 0;
// int firstRow = 0;
// int rowsIndex = 1;
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     minSum = minSum + array[firstRow, j];
// }
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     for (int k = 0; k < array.GetLength(1); k++)
//     {
//         sum = sum + array[i,k];
//     }
//     if (sum < minSum || sum == minSum)
//     {
//         {
//             minSum=sum;
//             rowsIndex = i + 1;
//         }
//     }
//     sum = 0;
// }
// // Console.WriteLine($"В массиве {count} строк(а/и) с минимальной сумой элементов");
// Console.WriteLine($"Строка №{rowsIndex} содержит минимальную сумму элементов({minSum})");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void PrintArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Даны две матрицы:");
// int size=new Random().Next(2, 5);
// int[,] firstArray = new int [size,size];
// int[,] secondArray = new int [size,size];
// PrintArray(firstArray);
// Console.WriteLine();
// PrintArray(secondArray);
// int[,] thirdArray = new int [size,size];
// Console.WriteLine("Выведем результирующую матрицу (произведение двух матриц):");
// for (int i=0;i<size;i++)
// {
//     for (int j=0;j<size;j++)
//     {
//         thirdArray[i,j]=0;
//         for (int k=0;k<size;k++)
//         {
//             thirdArray[i,j]=thirdArray[i,j]+(firstArray[i,k]*secondArray[k,j]);
//         }
//         Console.Write($" {thirdArray[i,j]}");
//         }     
//     Console.WriteLine();   
// }

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// double [,,] array=new double [2,2,2];
// int n=1;
// int m=2;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int j=0;j<array.GetLength(1);j++)
//     {
//         for (int k=0;k<array.GetLength(2);k++)
//         {
//             array[i,j,k]=Math.Round(new Random().NextDouble()*(n+m));
//             Console.Write($" {array[i,j,k]} ({i},{j},{k}) ");
//             n+=5;
//             m+=5;
//         }
//         Console.WriteLine();
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int n=4;
// int [,] array =new int [n,n];
// int i=0;
// int j=0;
// int num=1;
// while (num<=n*n)
// {
//     array[i,j]=num;
//     if (i<=j+1 && i+j<n-1) j++;
//     else if (i<j && i+j>=n-1) i++;
//     else if (i>=j && i+j>n-1) j--;
//     else i--;
//     num++;
// }

// PrintArray(array);


