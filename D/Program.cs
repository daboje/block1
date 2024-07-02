string[] FillArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i += 1)
        Console.Write($"“{array[i]}”, ");
    Console.Write($"“{array[array.Length-1]}”]");
    Console.WriteLine();
}

string[] ResultArray(string[] array)
{
    int sz = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) sz += 1;
    }
    string[] arrayRes = new string[sz];
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            arrayRes[j] = array[i];
            j += 1;
        }
    }
    return arrayRes;
}

string[] arraySet = FillArray();
Console.WriteLine();
Console.WriteLine("Первоначально заданный массив:");
PrintArray(arraySet);
Console.WriteLine();               
string[] arrayRes = ResultArray(arraySet);
Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(arrayRes);