/*
Написать программу, которая из массива строк, формирует массив
длинна строк элементов которого <= 3 символа.
Первоначальный массив можно ввести, либо задать.
Пример: ["hello","2","world",":-)"] -> ["2",":-)"]
*/

Console.Clear();
string[] Array = BeginArray();
string[] Result = ResultArray(Array, 3);

string[] ResultArray(string[] input, int n)
{
    string[] array = new string[FillArray(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            array[j] = input[i];
            j++;
        }
    }
    return array;
}

int FillArray(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] BeginArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}