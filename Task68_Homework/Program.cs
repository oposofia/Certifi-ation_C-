// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int numM, int numN) 
{
    if (numM == 0) return numN+1;
    if (numN == 0)
    {
        return Akkerman(numM - 1, 1); 
    } 
    else 
    {
        return Akkerman(numM - 1, Akkerman(numM, numN-1));
    }
}

Console.WriteLine("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n < 0) || (m < 0))
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

Console.WriteLine(Akkerman(m,n));