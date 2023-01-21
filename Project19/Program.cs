// Массивы
// Список друзей
// string f1="Anna";
// string f2="Bob";
// string f3="Alex";
// string f4="Ira";
// string f5="Mila";

// // string[] friends;
// string[] friends={f1,f2,f3,f4,f5, "John",Convert.ToString(1)};
// string[] friends={"Anna","Bob","Alex","Ira","Mila"};
// int [] num;
// int [] num=new int[5];
// int [] num={1,2,3,4,5};
// Console.WriteLine(friends[4]);
// friends[1]="Roman";
// Console.WriteLine(friends[1]);
// Console.WriteLine(friends.Length);
// for (int i=0; i<friends.Length; i++)
// {
//     Console.WriteLine(friends[i]);
// }
// Перебор массива
// foreach (int n in num)
// {
//     Console.WriteLine(n);
// }

// foreach (string n in friends)
// {
//     if (n!="John")
//     Console.WriteLine(n);
// }

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.Write("Введите координату точки по оси X:");
// int x=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки по оси y:");
// int y=Convert.ToInt32(Console.ReadLine());
// if (x>0 && y>0)
// {
//    Console.WriteLine("Точка находится в первой четверти");
// }
// else if (x<0 && y>0)
// {
//    Console.WriteLine("Точка находится во второй четверти");
// }
// else if (x>0 && y<0)
// {
//    Console.WriteLine("Точка находится в четвертой четверти");
// }
// else
// {
//  Console.WriteLine("Точка находится в третьей четверти");
// }

//  Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.Write("Введите номер четверти от 1 до 4: ");
// int q=Convert.ToInt32(Console.ReadLine());
// if (q==1)
// {
//     Console.WriteLine("Точка может находится в диапазонe координат точек (x,y), где x>0 и y>0 ");
// }

// else if (q==2)
// {
//     Console.WriteLine("Точка может находится в диапазонe координат точек  (x,y), где x>0 и y<0 ");
// }
// else if (q==3)
// {
//     Console.WriteLine("Точка может находится в диапазонe координат точек (x,y), где x<0 и y<0 ");
// }
// else if (q==4)
// {
//     Console.WriteLine("Точка может находится в диапазонe координат точек (x,y), где x<0 и y>0 ");
// }
// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.Write("Введите число N: ");
// double N=Convert.ToInt32(Console.ReadLine());

// for (double i=1;i<=N;i++)
// {
//     Console.WriteLine(Math.Pow(i,2));
// }
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Console.Write("Введите координату x первой точки: ");
// double x1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y первой точки: ");
// double y1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x второй точки: ");
// double x2=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y второй точки: ");
// double y2=Convert.ToInt32(Console.ReadLine());
// double L=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
// Console.WriteLine($"Длина заданного отрезка {Math.Round(L,2)}");

