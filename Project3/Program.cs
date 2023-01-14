// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
// Например
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write ("Max = ");
Console.WriteLine (max);
