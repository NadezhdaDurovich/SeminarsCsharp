// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// Например
//  5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите предел анализируемого диапазона от 1 до...");
int N = Convert.ToInt32(Console.ReadLine());
int number=1;
Console.Write("Все чётные числа диапазона: ");
while (number<N)
{
    if (number%2==0)
    {
        Console.Write (number);
        Console.Write (" ");
        number++;
    }
    else
    {
        number++;
    }
}