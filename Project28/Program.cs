// ДЗ к Семинару №9 «Рекурсия»

// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите любое число: ");
// int N=Convert.ToInt32(Console.ReadLine());
// void ListOfNumbers (int N)
// {
// 	if (N==1) Console.Write ("1");
//     else
//     {
//         Console.Write($"{N}");
//         ListOfNumbers (N-1);
//     }
// }
// Console.WriteLine($"Выведем список всех натуральных чисел от {N} до 1:");
// ListOfNumbers (N);

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M=new Random().Next(0,11);
// int N=new Random().Next(0,11);
// Console.WriteLine($"Найдем сумму чисел в промежутке между {M} и {N}: ");
// int SumOfNumbers (int M, int N)
// {
//     if (M==0) return (N*(N+1))/2;
//     else if (N==0) return (M*(M+1))/2;
//     else if (M==N) return M;
//     else if (M<N) return N+=SumOfNumbers(M,N-1);
//     else return N+=SumOfNumbers(M,N+1);
// }
// Console.WriteLine($"Получилось {SumOfNumbers (M, N)}");


// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Console.Write("Введите число m: ");
// int m=Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.Write("Введите число n: ");
// int n=Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int Akkerman (int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// Console.WriteLine($"Результат вычисления функции Аккермана: {Akkerman (m,n)}");



// Семинар №9
// Задача. Поиск факториала числа n с помощью рекурсии:
// int Factorial (int number)
// {
//     if (number==1) return 1;   
//     return number*Factorial(number-1); 
// }
// Console.WriteLine(Factorial(5));

// Вывести все натуральные числа от 1 до N
// int N=5;
// void  ListOfNaturalNumbers(int N)
// {
//     if (N==1) Console.Write ($"{N}");
//     else
//     {
//         ListOfNaturalNumbers(N-1);
//        Console.Write ($"{N}");
//     }
// }
// ListOfNaturalNumbers(N);

// Вывести все натуральные числа от M до N
// int M=1;
// int N=5;
// void  ListOfNaturalNumbers(int N,int M)
// {
//     if (N==M) Console.Write ($"{M}");
//     else
//     {
//        ListOfNaturalNumbers(N-1, M);
//        Console.Write ($"{N}");
//     }
// }
// ListOfNaturalNumbers(N,M);

// Задача: Напишите программу, которая принимает на вход число 
// и возвращает сумму его цифр
// int SumOfNumberElements(int N)
// {
//     if (N<10) return N;
//     else
//     {
//         return N%10+SumOfNumberElements(N/10);
//     }
// }
// int N=45;
// Console.WriteLine(SumOfNumberElements(N));
// ДОДЕЛАТЬ Задача: Напишите программу, которая принимает на вход числа A и B
// и возвожит число A в целую степень B (с помощью рекурсии)
// int Exponentiation (int A,int B)
// {
//     if (B==1) return A*A;
//     else
//     {
//         return Math.Pow(A,+SumOfNumberElements(N/10);
//     }
// }
// int N=45;
// Console.WriteLine(SumOfNumberElements(N));