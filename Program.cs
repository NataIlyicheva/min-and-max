Console.WriteLine("Введите первое число.");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число.");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine($"{number1} максимальное число");
    Console.WriteLine($"{number2} минимальное число");
}
else{
    Console.WriteLine($"{number2} максимальное число");
    Console.WriteLine($"{number1} минимальное число");
}