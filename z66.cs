// Задача 66: Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120; M = 4; N = 8. -> 30

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n большее m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма натуральных элементов от {m} до {n} равна {SummaRec(m, n)}");

int SummaRec(int m, int n)
{
    if (m == n) return m;
    return (SummaRec(m, n - 1) + n);
}
