// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("---------------Задача №1 (64)---------------");
// Console.WriteLine("Введите число: ");
// int N1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {PrintNatureNumber(N1)}");

// string PrintNatureNumber (int Number)
// {
//     if (Number == 1) return Number.ToString();
//     return (Number + " " + PrintNatureNumber(Number - 1));
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("---------------Задача №2 (66)---------------");
Console.WriteLine("Введите число M: ");
int M2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {SumNumbers(M2, N2)}");

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers(start + 1, end));
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29