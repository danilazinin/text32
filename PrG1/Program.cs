﻿Console.WriteLine("Введите 3 числа:");
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());

int sum = a + b + c;
int arg = sum/3;
Console.WriteLine($"Среднее арифметическое равно {arg} ");