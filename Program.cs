// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(20);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

void CheckNumbers(int[] mass)
{
    int[] massNew = new int[mass.Length];
    for (int i = 0; i < massNew.Length; i++)
    {
        massNew[i] = mass[i];
        if (massNew[i] % 2 == 0)
        {
            Console.Write($"{massNew[i]} ");
        }
    }
}

int[] mass = new int[5];
FillArray(mass);
PrintArray(mass);
Console.WriteLine();
Console.Write($"Четные числа в массиве mass: ");
CheckNumbers(mass);

