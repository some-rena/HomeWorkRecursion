
// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void PrintNumbersFromMtoN(int m, int n)
{

    if (m == n)
    {
        Console.Write($"{m} ");

        return;
    }
    Console.Write($"{m}, ");

    int correntM;
    if (m > n)
    {
        correntM = m - 1;
    }
    else
    {
        correntM = m + 1;
    }

    PrintNumbersFromMtoN(correntM, n);

}

bool isNumbers(string text)
{

    if (int.TryParse(text, out int number))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели не число!");
        return false;
    }
}

int m;
int n;
string text;

Console.Write("Введите первое число: ");

text = Console.ReadLine();
if (isNumbers(text))
{
    m = Convert.ToInt32(text);
}
else
{
    return;
}
Console.Write("Введите второе число: ");
text = Console.ReadLine();
if (isNumbers(text))
{
    n = Convert.ToInt32(text);
}
else
{

    return;
}

PrintNumbersFromMtoN(m, n);
