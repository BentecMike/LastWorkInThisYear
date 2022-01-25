// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//int[] mass = {-1, 3, 2, 10, 15};
//string[] mass = {"hello", "2", "world", ":-)"};

void FillArray(int[] mass)
{
    int length = mass.Length;
    int index = 0;
    while (index < length)
    {
        mass[index] = new Random().Next(20);
        index++;
    }
}

void PrintArray(int[] mass)
{
    int count = mass.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{mass[position]} ");
        position++;
    }
}

int[] Checkmass(int[] mass)
{
    int[] massNew = new int[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    { 
        if(mass[i] % 2 == 0) 
        {   
            massNew[i] = mass[i];
        }
    }    
    return massNew;
}

int[] mass = new int[20];
FillArray(mass);
PrintArray(mass);
Checkmass(mass);
Console.WriteLine();
int[] massNew = Checkmass(mass);
massNew = massNew.Where(x => x != 0).ToArray();
PrintArray(massNew);



