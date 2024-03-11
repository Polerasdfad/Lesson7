// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.



static void recurs_natural(int m, int n)
{
    if (m > 0 && m <= n)
    {
        Console.WriteLine(m);
    }
    else if (m > 0 && m >= n)
    {
        Console.WriteLine(m);
    }
    if (m < n)
    {
        recurs_natural(m + 1, n);
    }
    else if (m > n)
    {
        recurs_natural(m - 1, n);
    }
}
recurs_natural(20, -20);
