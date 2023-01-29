// Домашнее задание к семинарам №3 "Базовые алгоритмы" и №4 "Функции"

// Задача №19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Например, 14212->нет, 12821->да,23432->да

// Console.Write("Введите 5-значное число: ");
// int N=Convert.ToInt32(Console.ReadLine());
// if (N>=10000 && N<=99999) 
// {
//     if  ((N/10000==N%10)&&(((N/1000)%10)==((N/10)%10)))
//     {
//     Console.WriteLine($"Число {N} является палиндромом");
//     }
//     else
//     {
//     Console.WriteLine($"Число {N} не является палиндромом");
//     }
// }
// else
// {
// Console.WriteLine("Ошибка ввода: число должно быть 5-значным!");
// }


// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D-пространстве. Например:
// A(3,6,8), B(2,1,-7) -> 15.84
// A (7,-5,0), B(1,-1,9) -> 11.53

// double FindDistanceIn3D(double x1, double y1, double z1, double x2, double y2, double z2)
// {
// double distance=Math.Sqrt (Math.Pow ((x2-x1),2)+ Math.Pow ((y2-y1),2)+ Math.Pow ((z2-z1),2));
// return distance;
// }
// Console.WriteLine("Введите координаты первой точки: ");
// Console.Write("по оси x: ");
// double x1=Convert.ToInt32(Console.ReadLine());
// Console.Write("по оси y: ");
// double y1= Convert.ToInt32(Console.ReadLine());
// Console.Write("по оси z: ");
// double z1=  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: ");
// Console.Write("по оси x: ");
// double x2=  Convert.ToInt32(Console.ReadLine());
// Console.Write("по оси y: ");
// double y2= Convert.ToInt32(Console.ReadLine());
// Console.Write("по оси z: ");
// double z2= Convert.ToInt32(Console.ReadLine());
// Console.Write($"Расстояние между точкой A({x1},{y1},{z1}) и точкой B({x2},{y2},{z2})");
// Console.WriteLine($"в 3-хмерном пространстве = {Math.Round(FindDistanceIn3D(x1,y1,z1,x2,y2,z2),2)}");


// Задача №23. Напишите программу, которая принимает на вход число N и выдает 
// таблицу кубов чисел от 1 до N. Например: 3 ->1,8,27; 5 - >1,8,27,64,125

// Console.Write("Введите любое число: ");
// int N=Convert.ToInt32(Console.ReadLine());
// for (int i=1;i<=Math.Abs(N);i++)
// {
//     Console.Write($"{Math.Pow(i,3)} ");
// }



// Задача №25. Напишите цикл, который принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В. Например: 3,5 - >243 (35), 2,4 ->16

// 1-й вариант решения:

// Console.Write("Введите число: ");
// int A=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение степени для возведения: ");
// int B=Convert.ToInt32(Console.ReadLine());
// double c=1;
// for (int i=0;i<B;i++)
// {
//     c=c*A;
// }
// Console.WriteLine($"Результат возведения числа {A} в {B}-ую степень: {c}");

// 2-й вариант решения
int ToThePower (int A, int B)
{
    int res=A;
    for (int i=1;i<B;i++)
    {
        res*=A;
    }
    return res;
}
Console.Write("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение степени для возведения: ");
int B=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат возведения числа {A} в {B}-ую степень: {ToThePower (A,B)}");

// 3-й вариант решения
// double Exponent (int A, int B)
// {
// double result=0;
// result= result+Math.Pow(A,B);
// return result;
// }
// Console.Write("Введите число: ");
// int A=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение степени для возведения: ");
// int B=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат возведения числа {A} в {B}-ую степень: {Exponent (A,B)}");


// Задача №27. Напишите программу, которая принимает на вход число 
// и выдает сумму цифр в числе. Например: 452->11, 82 ->10, 9012- >12


// int CountQuantity (int N)
// {
// int count=1;
// int y=N;
// while ((y/10)!=0)
// {
//     count++; 
//     y=y/10;
// }
// return count;
// }
// Console.Write("Введите число: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int i= CountQuantity (N);
// double sum=N%10;
// int x=N;
// for (int j=0;j<i;j++)
// {
//     x= x/10;
//     sum=sum+(x%10);
// }
// Console.WriteLine($"Сумма цифр в чиcле {N} – {sum}");


// Задача №29.Напишите программу, которая задает массив из 8 элементов 
// и выводит их на экран. Например: 1,2,5,7,19 - >[1,2,5,7,19], 6,1,33 - > [6,1,33]

// 1-й вариант решения:

// int[] array=new int [8];
// Console.WriteLine("Выводим на экран массив случайных чисел из 8 элементов от 1 до 100:");
// for (int i=0;i<array.Length;i++)
// {
//     array[i]=new Random().Next(1,101);
//     Console.Write($"{array[i]} ");
// }
// 2-й вариант решения:

// int[] Array (int number, int[] numbers)
// {
//     for (int i=0;i<number;i++)
//     {
//         numbers[i]=new Random().Next(0,1000);
//         Console.Write (numbers[i]);
//         Console.Write (" ");
//     }
//      return numbers;
// }
// Console.WriteLine("Cоздадим массив случайных чисел?");
// Console.Write("Введите желаемое количество элементов массива:");
// int num=Convert.ToInt32(Console.ReadLine());
// int[] array=new int [num];
// Console.Write ("[");
// Array(num,array);
// Console.Write ("]");
