//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
string Len(int stop, int start)
{
  if (start == stop) return Convert.ToString(stop);
    return start + " " + Len(stop, start + 1);
}

Console.WriteLine("Введите число m");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(m, n));