// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 1000)
{
    int lastdigit = (a % 10); 
Console.WriteLine(lastdigit);
}
else 
{
    Console.WriteLine("Необходимо ввести трехзначное число");
}