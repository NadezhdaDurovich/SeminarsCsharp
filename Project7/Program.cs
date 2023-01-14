// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру
Console.Write("Введите номер дня недели (целое число от 1 до 7): ");
int number=Convert.ToInt32(Console.ReadLine());
if (number==1) Console.WriteLine ($"День недели под номером {number} - это Понедельник.");
if (number==2) Console.WriteLine ($"День недели под номером {number} - это Вторник.");
if (number==3) Console.WriteLine ($"День недели под номером {number} - это Среда.");
if (number==4) Console.WriteLine ($"День недели под номером {number} - это Четверг.");
if (number==5) Console.WriteLine ($"День недели под номером {number} - это Пятница.");
if (number==6) Console.WriteLine ($"День недели под номером {number} - это Суббота");
if (number==7) Console.WriteLine ($"День недели под номером {number} - это Воскресенье");
