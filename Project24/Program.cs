// Задания к семинару №5 «Функции и одномерные массивы»

//Задача №34. 
//Задайте массив, заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет
// количество четных чисел в массиве.Например,[345,897,568,234]->2.

// Console.Write("Введите желаемое количество элементов массива: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Выведем массив случайных чисел: ");
// Console.Write("[ ");
// int[] array = new int[numb];
// int count = 0;
// for (int i = 0; i < numb; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write($"{Math.Abs(array[i])} ");
//     if (array[i] % 2 == 0) count++;
// }
// Console.WriteLine("]");
// Console.WriteLine($"Среди элементов данного массива - {count} четных числа");

// Задача №36.
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях. 
// Например, [3,7,23,12] -> 19, [-4,-6,89,6] -> 0.


// int SumOfOddArrayElements(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum += array[i];
//     }
//     return sum;
// }
// Console.Write("Введите желаемое количество элементов массива: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[numb];
// Console.Write("Выведем массив случайных чисел: ");
// Console.Write("[ ");
// for (int i = 0; i < numb; i++)
// {
//     array[i] = new Random().Next(-100, 101);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine("]");
// Console.WriteLine($"Сумма элементов данного массива, стоящих на нечетных позициях, = {SumOfOddArrayElements(array)}.");

// Задача №38.
// Задайте массив вещественных чисел.  Найдите разницу
// между макс. и мин.элементами массива. Например, [3 7 22 2 78] -> 76.

// void PrintArray(int numb, int [] array)
// {
//     Console.Write("Представлен массив случайных чисел: ");
//     Console.Write("[ ");
//     for (int i=0; i<numb;i++)
//     {
//         array[i]=new Random().Next(0,101);
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine("]");
// }
// Console.Write("Введите желаемое количество элементов массива: ");
// int numb=Convert.ToInt32(Console.ReadLine());
// int [] array=new int [numb];
// PrintArray(numb,array);
// int maxInteger=array[0];
// int minInteger=array[0];
// int i=0;
// while (i<numb)
// {
//     if (array[i]>maxInteger) maxInteger = array[i];
//     if (array[i]<minInteger) minInteger = array[i];
//     i++;
// }
// Console.WriteLine($"Разность между макс. и мин. элементами данного массива = {maxInteger-minInteger}.");
