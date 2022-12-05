// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("First number большее, second number меньшее. ");
}
else
{
    Console.Write("Second number большее, first number меньшее. ");
}
if (num1==num2)
{
    Console.Write("First number равен second number.");
}
else
{
    Console.Write("First number не равен second number.");
}
