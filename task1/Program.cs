// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Clear();

int AckermanFunctionCalculation(int m, int n) // Вычесление функции Аккермана
{
    if (m == 0) 
    {
    return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
    return AckermanFunctionCalculation(m - 1, 1);
    }
    else 
    {
    return AckermanFunctionCalculation(m - 1, AckermanFunctionCalculation(m, n - 1));
    }
}


Console.Write("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.Write("Необходимо ввести неотрицательные числа!");
}
else
{
Console.Write(AckermanFunctionCalculation(m, n));
}