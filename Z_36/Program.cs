/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


Console.Clear();

int  getUserData (string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int [] Fillarray(int length, int start, int end)
{
    int [] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int SumNumberOfQuantity(int [] array, int number)
{   
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(i % 2 == 1)
            {
                result = result + array [i];
            }
    }
    return result;
}

int [] printArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    return array;
}

int number = getUserData("Введите количество элементов массива");
int[] array = Fillarray(number, -100, 100);
int [] Array = printArray(array);
int quantity = SumNumberOfQuantity(array, number);

Console.WriteLine($"{Array} -> {quantity}");