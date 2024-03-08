// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

int n = 3;
int m = 2;

int FuncAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else if(m == 0)
    return FuncAkkerman(n - 1, 1);
  else
    return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
}

Console.Write($"При n={n} и m={m} функция Аккермана равна {FuncAkkerman(n, m)}");
