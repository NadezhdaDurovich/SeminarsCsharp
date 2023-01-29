// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int y=10;
int ThirdDigit (int x)
{
int result=-1;
   if (x>99)
   {
      while(x>999)
      {
         x=x/y;
      }
      result=x%y;
   }
return result;
}
Console.Write("Введите любое число: ");
int N=Convert.ToInt32(Console.ReadLine());
int x=N;
if (ThirdDigit(N)==-1)
{
   Console.WriteLine($"В числе {N} третьей цифры нет");  
}
else
{
   Console.WriteLine($"В числе {N} третья цифра слева - это {ThirdDigit(N)}");
}
// Console.Write("Введите любое число: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int x=N;
// int y=10;
// int count=100;
// if ((N/count)==0)
// {
//    Console.WriteLine($"В числе {N} третьей цифры нет");  
// }
// else
// {
//     while ((x/y)!=0)
//     {
//        x=x-x%y;
//        y=y*10;
//     }
//     Console.WriteLine($"В числе {N} третья цифра слева - это {(N%(y/100)-((N%(y/100))%(y/1000)))/(y/1000)}"); 
// }