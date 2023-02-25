/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, 100, 1000);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"В массиве: [{String.Join(";", array)}] четных чисел {count}");