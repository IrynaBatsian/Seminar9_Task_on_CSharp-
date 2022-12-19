// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int rec(int n)
{
  if (n % 10 == n || n < 10 || n / 10 ==0) // Можно использовать любой из этих трех базисов. 
    return n;
  return rec(n / 10) + n % 10;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));