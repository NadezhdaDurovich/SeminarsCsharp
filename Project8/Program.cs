// Напишите программe, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа от -N до N
// Например
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 -> -2, -1, 0, 1, 2
Console.Write("Введите любое положительное число: ");
int N=Convert.ToInt32(Console.ReadLine());
int number=-N;
Console.WriteLine($"Все целые числа от {-N} до {N}: ");
while (number<=N)
{
    if(number%1==0)
    {
        Console.Write(number);
        Console.Write(" ");
        number++;
    }
    else
    {
        number++;
    }
}
