Console.WriteLine("Введите 3 числа:");
Console.WriteLine("Введите первое число:");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double  b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
double  c = int.Parse(Console.ReadLine());

double sum = a + b + c;
double arg = sum/3;
Console.WriteLine($"Среднее арифметическое равно {arg} ");