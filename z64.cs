// Задача 64: Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии. N = 5 -> "5, 4, 3, 2, 1"; N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"все натуральные числа от {n} до 1 выглядят как {numbers(n)}");

string numbers(int n)
{
    if (n == 0) return " ";
    return n + ", " + numbers(n-1);
}
