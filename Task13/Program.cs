// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input number: ");
string number = Console.ReadLine();

if (number.Length < 3)
     Console.WriteLine("третьей цифры нет");
 else 
     Console.WriteLine(number[2]);
     Console.ReadKey();