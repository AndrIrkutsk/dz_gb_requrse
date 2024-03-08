// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int M = 10;
int N = 15;

void PrintNumNatDiapazone(int M, int N)
{
  if(M > N)
    return;
  Console.Write($"{M} ");
  PrintNumNatDiapazone(M + 1, N);
}

PrintNumNatDiapazone(M, N);
