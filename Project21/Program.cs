// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А. 7 -> 28 4 -> 10 8 -> 36 

// Console.Write("Введите число:");
// int A=Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for (int i=1;i<=A;i++)
// {
//     sum+=i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");


// Напишите программу, которая принимает на вход число и выдаёт
//  количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5 
// int CountNumbers(int N)
// {
//     int sum=0;
//     while (N!=0)
//     {
//         sum+=1;
//         N=N/10;
//     }
//     return sum;
// }
// Console.Write("Введите число:");
// int N=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumbers(N));


// Напишите программу, которая принимает на вход число N и выдаёт
//  произведение чисел от 1 до N. 4 -> 24  5 -> 120 

// int Factorial(int n)
// {
//     int f=1;
//     if (n>0)
//     {
//         for (int i=1;i<=n;i++)
//         {
//             f*=i;
//         }
//     }
//     return f;
// }
// Console.Write("Введите число:");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(n));

// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

// void RandomArray()
// {
// int[] array=new int[8];
// for (int i=0;i<array.Length;i++)
// {
//     array[i]=new Random().Next(0,2);
// }
// foreach (int n in array)
// {
//    Console.WriteLine(array[n]); 
// }
// }
// RandomArray();


