/*  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Clear();

int  getUserData (string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}


int size = getUserData ("Введите количество элементов массива: ");
double[] number = new double[size];
FillArray(number);
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;


for (int i = 0; i < number.Length;i++)
{
    if (number[i] > max)
        {
            max = number[i];
        }
    if (number[i] < min)
        {
            min = number[i];
        }
}

Console.WriteLine($"-> Максимальный элемент - {max}, минимальный элемент - {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива - {max - min}");

void FillArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(1000,10000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write("; ");
            }
        }
    Console.Write("]");
    return;

}

