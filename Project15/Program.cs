﻿// Напишите программу, которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа.  456 -> 46 782 -> 72 918 -> 98

int N=new Random().Next (100,1000);
Console.WriteLine($"Random number is {N}");
// int a=N/100;
// int b=N%10;
Console.WriteLine($"Удаляем вторую цифру и получаем число {N/100*10+N%10}");

