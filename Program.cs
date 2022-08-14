//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( Math.Pow(a, n));