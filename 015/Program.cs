/*
Задача 15: Напишите программу,
 которая принимает на вход цифру,
  обозначающую день недели, и проверяет,
   является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/
Console.WriteLine("Введите число от 1 до 7  чтобы узнать какой день недели считается выходным ))");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == 1)
{
Console.WriteLine("нет");
}
else if (firstNumber == 2)
{
Console.WriteLine("нет");
}
else if (firstNumber == 3)
{
Console.WriteLine("нет");
}
else if (firstNumber == 4)
{
Console.WriteLine("нет");
}
else if (firstNumber == 5)
{
Console.WriteLine("нет");
}
else if (firstNumber == 6)
{
Console.WriteLine("Суббота ! да это выходной");
}
else if (firstNumber == 7)
{
Console.WriteLine("Воскресенье ! да это выходной");
}
else
{
Console.WriteLine("Просил же число от 1 до 7");
}