// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] array = new int []{1, 2, 5, 0, 10, 34};

void PrintArray(int[] mas , int indexToPrint)
{
  if(indexToPrint >= 0)
  {
    Console.WriteLine(mas[indexToPrint]);
    PrintArray(mas , indexToPrint - 1);
  }

}

PrintArray(array, array.Length - 1);