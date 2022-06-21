// Задача 1: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число A: ");
string ia = Console.ReadLine();
int a = int.Parse(ia);
System.Console.WriteLine("Введите число B: ");
string ib = Console.ReadLine();
int b = int.Parse(ib);
int i = 0;
long p = 1;

for (i = 0; i < b; i++)
{
    p = p * a;
}
System.Console.WriteLine($"{a} в степени {b} равно {p}");