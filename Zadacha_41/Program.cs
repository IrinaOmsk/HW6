//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] array = new int[InputIntNumber()];
EnterArray(array, 0);
PrintArray(array);
CountOfNumBiggerThenZero(array);

int InputIntNumber()
{
        Console.Write("Ведите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
}

void EnterArray(int[] array, int i)
{

    if (i < array.Length)
    {
        Console.Write($"Введите {i+1} эл-т массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
        EnterArray(array, i);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

void CountOfNumBiggerThenZero(int[] array)
{
    Random rand = new Random();
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше 0.");
}