/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений массива: ");
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, min, max);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
int sumOddPosition = 0;
for (int i = 1; i < size; i += 2)
{
    sumOddPosition = sumOddPosition + array[i];
}
Console.WriteLine($"В массиве: [{String.Join(";", array)}] сумма чисел на нечетных позициях равна {sumOddPosition}");