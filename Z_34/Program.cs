/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 
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

int FindQuantity(int [] array, int number)
{   
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] % 2 == 0)
            {
                result = result + 1;
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
int[] array = Fillarray(number, 100, 999);
int [] Array = printArray(array);
int quantity = FindQuantity(array, number);

Console.WriteLine($"{Array} -> {quantity}");





