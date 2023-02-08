// Задания к семинару №5 «Функции и одномерные массивы»

//Задача №34. 
//Задайте массив, заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет
// количество четных чисел в массиве.Например,[345,897,568,234]->2.

// int[] GetArray(int numb)
// {
//     int[] numbers=new int[numb];
//     for (int i=0;i<numbers.Length;i++)
//     {
//         numbers[i]=new Random().Next(100, 1000);
//         Console.Write($"{Math.Abs(numbers[i])} ");
//     }
//     return numbers;
// }
// int CountEvenArray (int [] nums)
// {
//     int count=0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if (nums[i] % 2 == 0) count ++;
//     }
//     return count;
// }
// Console.WriteLine("Выведем массив случайных положительных трехзначных чисел.");
// Console.Write("Задайте желаемую длину массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Среди элементов данного массива - {CountEvenArray(GetArray(number))} четных числа");

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

void PrintArray(int numb, double [] array)
{
    Console.Write("Представлен массив случайных чисел: ");
    Console.Write("[ ");
    for (int i=0; i<numb;i++)
    {
        array[i]=Math.Round(new Random().NextDouble()*numb,2);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
Console.Write("Введите желаемое количество элементов массива: ");
int numb=Convert.ToInt32(Console.ReadLine());
double [] array=new double [numb];
PrintArray(numb,array);
double maxInteger=array[0];
double minInteger=array[0];
int i=0;
while (i<numb)
{
    if (array[i]>maxInteger) maxInteger = array[i];
    if (array[i]<minInteger) minInteger = array[i];
    i++;
}
Console.WriteLine($"Разность между макс. и мин. элементами данного массива = {maxInteger-minInteger}.");
