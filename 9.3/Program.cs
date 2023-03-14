Console.Clear();
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SortingNumbers(m, n);
int n2 = Math.Abs(n);
Console.WriteLine($"Наибольший общий делитель чисел {m} и {n} равен: {GetGreatestCommonDivisorTwoNumbers(m, n, n2)}");
(int, int) SortingNumbers(int number1, int number2)
{
  int number3 = number1;
  if (Math.Abs(number1) < Math.Abs(number2))
  {
    number1 = number2;
    number2 = number3;
  }
  return (number1, number2);
}
int GetGreatestCommonDivisorTwoNumbers(int number1, int number2, int number3)
{
  if (number1 % number3 == 0 && number2 % number3 == 0) return number3;
  return GetGreatestCommonDivisorTwoNumbers(number1, number2, number3 - 1);
}
