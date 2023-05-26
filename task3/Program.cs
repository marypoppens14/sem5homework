// Задать массив вещественных чисел
// Найти разницу между максимальным и минимальным элементами массива
// найти макс и мин, из макса вычесть мин
double[] GenArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}

double[] array = GenArray(10);
double max = array.Max();
double min = array.Min();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Разница равна: {max - min}");