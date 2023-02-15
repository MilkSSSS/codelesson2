// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

int number = new Random.Next();

Console.WriteLine("Input a number");

char[] arr = number.ToString().ToCharArray();
Console.WriteLine($"Third number is {arr[2]}");