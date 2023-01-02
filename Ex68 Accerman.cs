// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//   if (m == 0) res = n + 1; else

//   if (m == 1) res = n + 2; else

//   if (m == 2) res = 2*n + 3; else res = (1 << (n + 3)) - 3;


uint Accerman(uint n, uint m)
{
    if (n == 0)
    {
        return (m + 1);
    }
    else
    if ((n != 0) && (m == 0))
        return Accerman(n - 1, 1);
    else
        return Accerman(n - 1, Accerman(n, m - 1));
}
Console.WriteLine(Accerman(3, 2));

// A(1, n) = n + 2,

// A(2, n) = 2n + 3,

// A(3, n) = 2n+3 – 3