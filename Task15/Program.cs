// Напишите программу, которая принимает на вход цифру, обозначающую день

Console.WriteLine("Укажите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if(day >= 6)
    if (day >=8)
        Console.WriteLine("Неделя состоит из 7 дней");
    else 
        Console.WriteLine("выходной");
else if (day <= 0)
Console.WriteLine("Неделя начниается с первого дня");
else if (day <= 5)
    Console.WriteLine("будни");