Console.Clear();
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0 || n < m) Console.Write($"Условие не корректно ");
else
{
  Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна: {GetSumElementsMtoN(m, n)}");
  int GetSumElementsMtoN(int min, int max)
  {
    if (max == min) return min;
    return (min + GetSumElementsMtoN(min + 1, max));
  }
}