// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число которое по порядку обозначат день недели");
int num = Int32.Parse(Console.ReadLine());
if(num>7) Console.WriteLine("Такого дня недели нет");
if(num<1) Console.WriteLine("Такого дня недели нет");
else if(num == 7) Console.WriteLine("Выходной");
else if(num == 6) Console.WriteLine("Выходной");
else if(num == 5) Console.WriteLine("Будний день");
else if(num == 4) Console.WriteLine("Будний день");
else if(num == 3) Console.WriteLine("Будний день");
else if(num == 2) Console.WriteLine("Будний день");
else if(num == 1) Console.WriteLine("Будний день");