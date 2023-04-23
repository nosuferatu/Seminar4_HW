// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int step = numberA;

for (int i = 1; i < numberB; i++)
{
step = step * numberA;
}
Console.WriteLine($"A в степени B = {step}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
int count = number % 10;
number = number / 10;
sum = sum + count;
}

Console.WriteLine($"Сумма цифр в числе = {sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Например:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + extract (i) + " ");
 }
Console.Write("]");

int extract (int t)
{
    return numbers[t];
}