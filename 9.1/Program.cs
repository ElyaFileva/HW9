Console.Clear();
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Четные числа от {m} до {n} --> ");
GetEvenNumbersFromMtoN(m, n);
void GetEvenNumbersFromMtoN(int min, int max)
{
  if (min < 0 || max < 0 || max < min) Console.Write($"Условие не корректно ");
  else
  {
    if (min % 2 != 0) min++;
    Console.Write("{0} ", min);
    if (min == max || min == max + 1) return;
    GetEvenNumbersFromMtoN(min + 2, max);
  }
}