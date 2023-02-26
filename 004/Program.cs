/*
Доп. задачка:
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = GetArray(size, new Random().Next(10), new Random().Next(10));

double[] GetArray(int size, double min, double max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round((new Random().NextDouble() * 200 - 100), 2);
    }
    return result;
}
int sizeProduct = size / 2 + size % 2;
int lastPosition = size-1;
double[] productArray = new double[sizeProduct];
int i = 0;

for (int k = 0; k < (sizeProduct); k++)
{
    productArray[k] = Math.Round(array[i] * array[lastPosition], 2);
    i++;
    lastPosition--;
}

Console.WriteLine($"Полученный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"'Произведенные' числа: {String.Join("; ", productArray)} ");