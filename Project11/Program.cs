// Цикл (Условный while и счётный for)
int a=5;

for (int i=0; i<10; i++)
{
    if (i==8||i==7)
    {
        continue;
        Console.WriteLine("111");
    }
    Console.WriteLine(i);
}
Console.WriteLine("OK");

// while (a<10)
// {
//     a++;
//     if (a==8)
//     {
//        continue; 
//     }
//     Console.WriteLine(a);
// }
// Console.WriteLine("ОК");

// while (a<=10)
// {
//     Console.WriteLine(a);
//     a++;
//     if (a==9)
//     {
//         break;
//     }
// }
// Console.WriteLine("ОК");
