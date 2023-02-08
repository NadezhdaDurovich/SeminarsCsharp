// Двумерные(двухранговые и много ранговые) массивы

// выводим на экран одномерный массив:
// int[] nums={1,2,3,4,5,6,7,8,9};
// foreach (var item in nums)
// {
//     Console.Write(item);  
// }

// выводим на экран двухмерный массив:
// int[,] nums2={{1,2,3},{4,5,6},{7,8,9},{0,4,2}};
// int[,] nums3=new int [4,3];

// foreach (var item in nums2)
// {
//     Console.Write(item);  
// }

// int[,] nums2={{1,2,3},{4,5,6},{7,8,9},{0,4,2}};
// for (int i=0;i<nums2.GetLength(0);i++)
// {
//    for (int j = 0; j < nums2.GetLength(1); j++)
//    {
//    Console.Write($"{nums2[i,j]} ");
//    }
//    Console.WriteLine();
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.) 
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// int [] array={1,2,3,4,5};
// int x=array.Length-1;
// for (int i=0;i<(array.Length/2);i++)
// {
//    int temp=array[x];
//    array[x]=array[i];
//    array[i]=temp;
//    x=x-1;
// }
//   foreach (var item in array)
//  {
//     Console.Write($"{item} ");
//  }  

// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон

// bool FindTriangle (int a, int b, int c)
// {
//     if (a<=(b+c) && b<=(a+c) && c<=(a+b))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }  
// Console.Write ("Введите длину первого отрезка: ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите длину второго отрезка: ");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите длину третьего отрезка: ");
// int c=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"Треугольник со сторонами такой длины может существовать? {FindTriangle(a,b,c)}");

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное. 45 -> 101101 3  -> 11 2  -> 10

// Console.Write("Введите любое число в десятичной системе счисления: ");
// int N=Convert.ToInt32(Console.ReadLine());
// string result=" ";// лучше использовать String.Empty;
// while (N>0)
// {
//     result=Convert.ToString(N%2)+result;//преобразовываем тип значения из числового в строковый  
//     // int x=N%2;
//     N/=2;
// }
//    Console.WriteLine(result);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8 

// Console.Write("Введите любое число: ");
// int N=Convert.ToInt32(Console.ReadLine());
// double [] array=new double[N];
// string fibonacci="0 1 ";
// int i=0;
// array[0]=0;
// array[1]=1;
// for (i=2;i<=N-1;i++)
// {
//     array[i]=array[i-2]+array[i-1];
//     fibonacci=fibonacci+Convert.ToString(array[i]+" ");
// }
// Console.WriteLine($"Число Фибоначчи от 0 до {N} -> {fibonacci}");

// Задача 46: Задайте двумерный массив размером m×n, заполненный 
// случайными целыми числами. m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1

// int m=3;
// int n=4;
// int [,] array= new int[m,n];
// Console.WriteLine($"Выведем двумерный массив [{m},{n}]: ");
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int j=0; j<array.GetLength(1);j++)
//     {
//         array[i,j]=new Random().Next(-10,100);
//         Console.Write($"[{array[i,j]}]");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран. m = 3, n = 4. 

// Console.Write ("Введите желаемое количество строк двумерного массива: ");
// int m=Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите желаемое количество столбцов двумерного массива: ");
// int n=Convert.ToInt32(Console.ReadLine());
// int [,] array =new int [m,n];
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int j=0; j<array.GetLength(1);j++)
//     {
//         array[i,j]=i+j;
//         Console.Write($"[{array[i,j]}]");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых
// оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Write("Введите желаемое количество строк двумерного массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите желаемое количество столбцов двумерного массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 101);
//         Console.Write($"[{array[i, j]}]");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// Console.Write("Новый массив:");
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             int sqr = Convert.ToInt32(Math.Pow(array[i, j], 2));
//             array[i, j] = sqr;
//             Console.Write($"[{array[i, j]}]");
//         }
//         else
//         {
//             Console.Write($"[{array[i, j]}]");
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 Сумма элементов 
// главной диагонали: 1+9+2 = 12

// Console.WriteLine("Создадим двумерный массив.");
// Console.Write("Количество строк: ");
// int m = new Random().Next(3,5);
// Console.WriteLine(m);
// Console.Write("Количество столбцов: ");
// int n = new Random().Next(3,5);
// Console.WriteLine(n);
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 11);
//         Console.Write($"[{array[i, j]}]");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// Console.Write("Найдем сумму элементов главной диагонали: ");
// int sum=0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i==j)
//         {
//             sum= sum+array[i,j];
//         }
//     }
// }
// Console.WriteLine(sum);

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] GetPrintArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
// int lines = new Random().Next(2, 5);
// int columns = new Random().Next(2, 5);
// Console.WriteLine($"Создадим двухмерный массив [{lines},{columns}]");
// // GetPrintArray(lines, columns);
// int[,] array = GetPrintArray(lines, columns);
// Console.WriteLine();
// int[] firstLine=new int[columns];
// int[] lastLine=new int[columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == 0)//(array.GetLength(0)-1))
//         {
//             int temp = array [i, j];
//             array[i, j] = array[lines-1, j];
//             // array[lines-1,j] = temp;
//             firstLine[j]=array[lines-1, j];
//             lastLine[j]=temp;
//             Console.Write($" {firstLine[j]} ");
//         }
//         else if (i==lines-1)Console.Write($" {lastLine[j]} ");
//         else Console.Write($" {array[i,j]} ");
//     }
//     Console.WriteLine();
// }



// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int lines = 3;//new Random().Next(2, 5);
int columns = 3;//new Random().Next(2, 5);
Console.WriteLine($"Создадим двухмерный массив [{lines},{columns}]");
int[,] array = GetPrintArray(lines, columns);
Console.WriteLine();
int[,] newArray = new int [array.GetLength(1), array.GetLength(0)];
if (array.GetLength(0)==array.GetLength(1))
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            if (i==j) 
            {
                newArray[i,j]=array[i,j];
                Console.Write($" {array[i,j]} ");
            }
            if (array[i,j]!=array[j,i])
            {
                int temp = array [i, j];
                array[i, j] = array[j,i];
                array[j,i] = temp;
                newArray[i,j]=array[j,i];
                Console.Write($" {newArray[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Поменять строки и столбцы невозможно");
}