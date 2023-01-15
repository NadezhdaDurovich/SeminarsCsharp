// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.  Например: 
// 78 -> 8
// 12-> 2
// 85 -> 8
int a=new Random().Next(10,99);
Console.WriteLine($"Random number - {a}");
int b=a%10;
int c=a/10;
if (c==b)
{
    Console.WriteLine("Цифры равны");
}
else if (c>b)
{
    Console.WriteLine($"Первая цифра числа {a} больше второй");
}
else
{
    Console.WriteLine($"Вторая цифра числа {a} больше первой");
}
