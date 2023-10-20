// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRangeNaturalNumbers(int numM, int numN) // 2,5 - 3,5 - 4,5 - 5,5
{
    if (numM == numN) return numM;
    if (numM < numN)
    {
        return numM + SumRangeNaturalNumbers(numM + 1, numN); //2 3 4
    } //return (5)+4+3+2
    else 
    {
        return numM + SumRangeNaturalNumbers(numM - 1, numN);
    }
    // else Console.Write($"{num1}");

}

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n < 1) || (m < 1))
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

if (m<n) Console.Write($"Сумма натуральных элементов между {m} и {n} -> ");
else Console.Write($"Сумма натуральных элементов между {n} и {m} -> ");
Console.WriteLine(SumRangeNaturalNumbers(m, n));

