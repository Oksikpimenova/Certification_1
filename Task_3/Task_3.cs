int A(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0)
  { 
    return A(m - 1, 1);
  }
  else 
  {
    return A(m - 1, A(m, n - 1));
  }
}

Console.WriteLine("Введите число m");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(A(m, n));