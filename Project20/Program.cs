// Методы

// Console.WriteLine("Привет, Python!");
// Console.WriteLine("Привет, Python!");
// Console.WriteLine("Привет, Python!");
// Console.WriteLine("Привет, Python!");
// Console.WriteLine("Привет, Python!");

// void SayLang()
// {
//     Console.WriteLine("Привет, Python!");
// }
// SayLang();
// SayLang();
// SayLang();
// SayLang();
// SayLang();

// void SayLang(string lang)
// {
//     Console.WriteLine($"Привет, {lang}  !");
// }
// SayLang("C#");
// string lang1="JavaScript";
// SayLang(lang1);
// SayLang("PHP");
// SayLang("C++");
// SayLang("Python");

// int SumNum (int numA, int numB)
// {
//     int result=numA+numB;
//     return result;
// }
// int x=SumNum (2,3);
// Console.WriteLine(x);
// int y=SumNum (7,4);
// Console.WriteLine(y);
// Console.WriteLine(SumNum(19,24));
int SumNum (int numA, int numB)
{
    if (numA>numB)
    {int result=numA-numB;
    return result;
    }
    else
    {
        int result=numB-numA;
        return result; 
    }
}
int x=SumNum (2,3);
Console.WriteLine(x);
int y=SumNum (7,4);
Console.WriteLine(y);
Console.WriteLine(SumNum(19,24));