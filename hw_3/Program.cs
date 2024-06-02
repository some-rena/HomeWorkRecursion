
// Задача 3: Задайте произвольный массив.
//  Выведете его элементы, начиная с конца. 
//  Использовать рекурсию, не использовать циклы.
//  [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void PrintReversArray(int[] numbers, int i = 0)
{
    if (i == numbers.Length)
    {
        return;
    }
    PrintReversArray(numbers, i + 1);
    Console.Write($"{numbers[i]} ");
}

int[] GetArray()
{
    int[] array = [1, 2, 5, 0, 10, 34];
    return array;
}

int[] arr = GetArray();
PrintReversArray(arr);