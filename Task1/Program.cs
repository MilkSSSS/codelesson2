// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Input the number");
int number = Convert.ToInt32(Console.ReadLine());
int weekend = Random.Next(6,8);
int weekday = Random.Next(1,6);

if (number == weekend)
Console.WriteLine("Today is weekend!!!");
else if (number == weekday)
Console.WriteLine("Today is weekday...");
else
Console.WriteLine("This day does not exist");