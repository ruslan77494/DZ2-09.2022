/*
Задача 10:
 Напишите программу,
 которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/


/*Console.WriteLine(" Пожалуйста Введите Число:   ");
int num = Convert.ToInt32(Console.ReadLine());

string strr = num.ToString();

Console.WriteLine($"{num} -> {strr[1]}");
*/


Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

if (num > 99 && num < 1000  )
{
    num = num % 100;
    num = num / 10;
    Console.WriteLine(num);
}
   

else
   Console.WriteLine("Это не трехзначное число же ");