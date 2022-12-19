// Дана последовательность чисел, завершающаяся числом 0. Найдите сумму всех этих чисел, не используя цикл.

int sum()
{
  int n = Convert.ToInt32(Console.ReadLine());
  if (n == 0)
     return 0;
  return sum() + n;
}

Console.Clear();
Console.WriteLine(sum());
