// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

int[] CreateArray(int lenArray)
{
  int[] numArray = new int[lenArray];
  Random rnd = new Random();

  for (int i = 0; i < lenArray; i++)
  {
    numArray[i] = rnd.Next(1, 10);
  }
  return numArray;
}

/////////// 1 variant

void PrintReverseArray(int[] array)
{
  if(array.Length == 0)
    return;
  Console.Write($"{array[array.Length - 1]} ");
  Array.Resize(ref array, array.Length-1);
  PrintReverseArray(array);
}

int lengthArray = 10;
int[] randArray = CreateArray(lengthArray);
PrintArray(randArray);
PrintReverseArray(randArray);

///////////////
// 2 variant
///////////////

// void PrintReverseArray(int[] array, int i)
// {
//   if(array.Length == i)
//     return;
//   PrintReverseArray(array, ++i);
//   Console.Write($"{array[i-1]} ");
// }

// int lengthArray = 10;
// int[] randArray = CreateArray(lengthArray);
// PrintArray(randArray);
// PrintReverseArray(randArray, 0);
