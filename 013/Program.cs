/*
Задача 13: Напишите программу,
 которая выводит третью цифру заданного числа или сообщает,
  что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет
*/



Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

if (num > 99 && num < 1000)
Console.WriteLine(num % 10);
else
   Console.WriteLine($"{num} ->  третьей цифры нет " );
