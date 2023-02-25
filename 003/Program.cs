/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int min = new Random().Next(10);
int max = new Random().Next(10);

double[] array = GetArray(size, min, max);

double[] GetArray(int size, double min, double max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round((new Random().NextDouble() * 200 - 100), 2);
    }
    return result;
}
var minNumber = array[0];
var maxNumber = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
    else if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
}
double diffResult = maxNumber - minNumber;
Console.WriteLine($"В массиве: [{String.Join(";", array)}] разница между {maxNumber} и {minNumber} элементами массива равна {Math.Round(diffResult, 2)}");