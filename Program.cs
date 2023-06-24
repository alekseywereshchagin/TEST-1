
//Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


//                         Решение


string[] Array = { "Yes", "2389", "8-)", "All", "Samara", "OK", "7777", "!!!" };
int LenNewArray = 0;
for (int i = 0; i <= Array.Length - 1; i++)
{
    if (Array[i].Length <= 3) LenNewArray++;
}

string[] newArray = new string[LenNewArray];

int idx = 0;
for (int i = 0; i <= Array.Length - 1; i++)
{
    if (Array[i].Length <= 3)
    {
        newArray[idx] = Array[i];
        idx++;
    }
}

void PrintArray(string[] Array, string sep)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i < Array.Length - 1)
            Console.Write($"{Array[i]}{sep} ");
        else
            Console.Write($"{Array[i]}");
    }
    Console.Write("]->[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 1)
            Console.Write($"{newArray[i]}{sep} ");
        else
            Console.Write($"{newArray[i]}");
    }
}

Console.Write("[");
PrintArray(Array, ",");
Console.Write("]");
