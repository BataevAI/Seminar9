// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от [M до N].
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int M, int N) 
{
        
        if (M == N) return N;

        return  N + SumNumber(M, N - 1);            
                           
}
 
Console.WriteLine("Введите число M, а мы выведем сумму всех натуральныx чисел в промежутке от M до N");

int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");

int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Итоговая сумма: {SumNumber(M, N)}"); 