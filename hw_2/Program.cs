// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Ack(int n, int m)
{

    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ack(n - 1, 1);
    }
    else
    {
        return Ack(n - 1, Ack(n, m - 1));
    }
}


bool isNumbers(string text)
{

    if (!int.TryParse(text, out int number))
    {
        Console.WriteLine("Вы ввели не число!");
        return false;
    }
    int num = Convert.ToInt32(text);
    if (num < 0)

    {
        Console.WriteLine("Вы ввели отрицательное число!");
        return false;
    }
    return true;

}
int m;
int n;
string text;

Console.Write("Введите положительное число M: ");

text = Console.ReadLine();
if (isNumbers(text))
{
    m = Convert.ToInt32(text);
}
else
{
    return;
}
Console.Write("Введите положительное число N: ");
text = Console.ReadLine();
if (isNumbers(text))
{
    n = Convert.ToInt32(text);
}
else
{

    return;
}

int result = Ack(n, m);
Console.Write(result);