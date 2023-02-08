// Задания к семинару №6 «Одномерные массивы, продолжение»

// Задача №41. 
// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше нуля ввел пользователь.
// Например, 0,7,8,-2,-2 -> 2; 1,-7,567,89,223 -> 3.

// int M=new Random().Next(2,5);
// Console.WriteLine($"Для выполнения задания нужно ввести несколько чисел, допустим, {M}.");
// int [] array=new int [M]; 
// int count=0;
// for (int i = 0; i < M; i++)
// { 
//     Console.Write($"Введите число №{i+1}: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     array[i]=m;
//     if (array[i]>0) count++;
// }
// Console.WriteLine($" Среди введенных значений количество чисел больше нуля = {count}");

// Задача №43.
//  Напишите программу, которая найдет точку пересечения 
// двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2.
// Значения b1, k1, b2, k2 задаются пользователем. 
// Например, b1=2, k1=5, b2=4, k2=9 -> 2 (-0,5; -0,5).

void FindIntersectionCoordinates(double a1,double b1,double a2,double b2)
{
   if (a1==a2 && b1==b2) Console.WriteLine ("Линии совпадают.");
   else if (b1==b2) Console.WriteLine ("Линии не пересекаются"); 
   else
   {
    double x=(a2-a1)/(b1-b2);
    double y=(b1*x)+a1;
    Console.WriteLine($"Найдена точка пересечения двух прямых:  ({x};{y})");
   }
}
Console.Write("Введите координату 1 первой прямой: ");
double b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 2 первой прямой: ");
double k1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 1 второй прямой: ");
double b2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 2 второй прямой: ");
double k2=Convert.ToInt32(Console.ReadLine());
FindIntersectionCoordinates(b1,k1,b2,k2);

// if (b1==b2) Console.WriteLine ("Линии не пересекаются");
// double x=(b2-b1)/(k1-k2);
// double y=(k1*x)+b1;
// Console.WriteLine($"Найдена точка пересечения двух прямых:  ({x};{y})");

// Доп.задача к 7-му семинару (это мое решение, похоже, слишком тяжелое -не дождалась сработки...):

// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа.

// for (int x1=1;x1<=150;x1++)
// {
//     for (int x2=1;x2<=150;x2++)
//     {
//         for (int x3=1;x3<=150;x3++)
//         {
//             for (int x4=1;x4<=150;x4++)
//             {
//                 for (int x5=1;x5<=150;x5++)
//                     {
//                         if ((Math.Pow(x1,5)+Math.Pow(x2,5)+Math.Pow(x3,5)+Math.Pow(x4,5))==Math.Pow(x5,5))
//                         {
//                             Console.WriteLine($"{x1},{x2},{x3},{x4},{x5}");
//                         }
//                     }
//             }
//         }
//     }
// }







