﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


long Akkerman (long n, long m) 

{
    long akk = 0;
if (n == 0) return m + 1; 
else if (m == 0) return Akkerman(n - 1, 1);

else 
{  
    akk = Akkerman(n - 1, Akkerman(n, m - 1));
}


return akk;
}
Console.WriteLine("Введите число N и M в качестве аргументов функции Аккерамна, а мы рискнем ее посчитать");

Console.WriteLine("Введите число N:");
long N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
long M = Convert.ToInt32(Console.ReadLine());

long akker = Akkerman(N, M);
Console.WriteLine($"Функция Аккермана при n = {N}, m = {M} будет равна: {akker}");
