//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите трехзначное число, чтобы вывести его вторую цифру");
int num = Int32.Parse(Console.ReadLine());
int num2 = num%100; 
int result = num2/10;
System.Console.WriteLine(result);