// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число, чтобы вывести его третью цифру");
int num = Int32.Parse(Console.ReadLine());
int num2 = num%1000;
int result = num2/100;
if(result==0) System.Console.WriteLine("нет третьей цифры");
else
{
System.Console.WriteLine(result);
}
