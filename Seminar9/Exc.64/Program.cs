﻿
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void RecN (int number) 

{
if (number == 0) return; 


else { Console.Write($"Число: {number}  "); RecN(number - 1);  }



}
Console.WriteLine("Введите число N, а мы выведем все натуральные числа в промежутке от N до 1");

int N = Convert.ToInt32(Console.ReadLine());

RecN(N);

