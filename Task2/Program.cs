// Факториал числа с помощью рекурсивной функции

int factorial(int n)
{
  Console.WriteLine($"{n} ");
  if (n == 0)
    return 1;
  return factorial(n - 1) * n;
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(factorial(n));
